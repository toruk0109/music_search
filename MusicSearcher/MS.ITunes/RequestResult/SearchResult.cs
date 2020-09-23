using MS.ITunes.Entity;

using Newtonsoft.Json;


namespace MS.ITunes.RequestResult
{
	public class SearchResult<T>
	{
		[JsonProperty("resultCount")]
		public int Count { get; set; }

		[JsonProperty("results")]
		public T[] Entities { get; set; }
	}
}
