using System.Collections.Generic;

using MS.Contracts.Entity;


namespace MS.Contracts
{
	public interface IMusicApiWrapper
	{
		IEnumerable<ITrack> FindTracksByArtist(string artistName, int limit);

		IEnumerable<IAlbum> FindAlbumsByArtists(string artistName, int limit);
	}
}
