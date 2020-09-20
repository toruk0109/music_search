namespace MS.Contracts
{
	public interface IMusicApiWrapper
	{
		void FindByArtists(string artistName, out object albums);
	}
}
