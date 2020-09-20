using System;

using MS.ITunes;


namespace MusicSearcher
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var musicApiWrapper = new ApiWrapper();
			musicApiWrapper.FindByArtists("Jack Johnson", out object albums);
			Console.WriteLine((string)albums);
		}
	}
}
