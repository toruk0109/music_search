using MS.Contracts.Entity;

using Newtonsoft.Json;


namespace MS.ITunes.Entity
{
	public class Track : ITrack
	{
		[JsonProperty("trackId")]
		public int Id { get; set; }

		[JsonProperty("artistId")]
		public int ArtistId { get; set; }

		[JsonProperty("artistName")]
		public string ArtistName { get; set; }

		[JsonProperty("collectionId")]
		public int AlbumId { get; set; }

		[JsonProperty("collectionName")]
		public string AlbumName { get; set; }

		[JsonProperty("trackName")]
		public string Name { get; set; }
	}
}
