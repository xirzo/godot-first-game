
	namespace firstgame.scripts.domain.generation;

	public class Cell
	{
		public int X { get; }
		public int Y { get; }
		public bool IsSolid { get; }
		public Cell(int x, int y, bool isSolid)
		{
			X = x;
			Y = y;
			IsSolid = isSolid;
		}
	}
