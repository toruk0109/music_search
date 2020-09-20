using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

using MS.Contracts;


namespace MS.ITunes
{
	public class ApiWrapper : IMusicApiWrapper
	{
		private const string UrlApi = "https://itunes.apple.com/search";

		public void FindByArtists(string artistName, out object albums)
		{
			artistName = artistName.Replace(' ', '+');
			string url = $"{UrlApi}?term={artistName}";
			albums = null;

			HttpWebRequest request = WebRequest.CreateHttp(url);

			using WebResponse response = request.GetResponse();
			using Stream stream = response.GetResponseStream();
			if (stream == null)
				throw new HttpRequestException("Во время запроса данных произошла ошибка: не удалось получить корректный результат");

			using var reader = new StreamReader(stream);

			string result = reader.ReadToEnd();

			albums = result;
		}
	}
}
