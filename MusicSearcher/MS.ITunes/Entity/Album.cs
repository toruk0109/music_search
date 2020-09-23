using System;

using MS.Contracts.Entity;

using Newtonsoft.Json;


namespace MS.ITunes.Entity
{
	public class Album : IAlbum
	{
		[JsonProperty("collectionId")]
		public int Id { get; set; }

		[JsonProperty("primaryGenreName")]
		public string Genre { get; set; }

		[JsonProperty("artistId")]
		public int ArtistId { get; set; }

		[JsonProperty("artistName")]
		public string ArtistName { get; set; }

		[JsonProperty("collectionName")]
		public string Name { get; set; }

		[JsonProperty("releaseDate")]
		public DateTime Date { get; set; }
	}
}
