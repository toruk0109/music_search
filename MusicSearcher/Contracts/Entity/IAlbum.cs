using System;


namespace MS.Contracts.Entity
{
	public interface IAlbum
	{
		DateTime Date { get; }

		string ArtistName { get; }

		string Genre { get; }

		string Name { get; }
	}
}
