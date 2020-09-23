using System;
using System.Collections.Generic;

using MS.Contracts.Entity;
using MS.ITunes;


namespace MusicSearcher
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var musicApiWrapper = new ApiWrapper();
			IEnumerable<IAlbum> albums = musicApiWrapper.FindAlbumsByArtists("Jack Johnson");

			foreach (IAlbum album in albums)
				Console.WriteLine($"Genre: {album.Genre}; Name: {album.Name}; Year: {album.Date.Year}");
		}
	}
}
