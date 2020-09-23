using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;

using MS.Contracts;
using MS.Contracts.Entity;
using MS.ITunes.Entity;
using MS.ITunes.RequestResult;

using Newtonsoft.Json;


namespace MS.ITunes
{
	public class ApiWrapper : IMusicApiWrapper
	{
		private const string UrlApi = "https://itunes.apple.com/search";

		public IEnumerable<ITrack> FindTracksByArtist(string artistName, int limit = 200)
		{
			return FindEntityByArtist<Track>(artistName, "musicTrack", limit);
		}

		public IEnumerable<IAlbum> FindAlbumsByArtists(string artistName, int limit = 200)
		{
			return FindEntityByArtist<Album>(artistName, "album", limit);
		}

		private static IEnumerable<T> FindEntityByArtist<T>(string artistName, string entity, int limit)
		{
			artistName = artistName.Replace(' ', '+');
			string url = $"{UrlApi}?term={artistName}&entity={entity}";
			if (limit > 0)
				url = $"{url}&limit={limit}";

			HttpWebRequest request = WebRequest.CreateHttp(url);

			using WebResponse response = request.GetResponse();
			using Stream stream = response.GetResponseStream();
			if (stream == null)
				throw new HttpRequestException("Во время запроса данных произошла ошибка: не удалось получить корректный результат");

			using var reader = new StreamReader(stream);

			string result = reader.ReadToEnd().Trim();
			var settings = new JsonSerializerSettings
			{
				DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
				Formatting = Formatting.Indented
			};
			var searchResult = JsonConvert.DeserializeObject<SearchResult<T>>(result, settings);

			return searchResult.Entities;
		}
	}
}
