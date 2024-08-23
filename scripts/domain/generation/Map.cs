	  namespace firstgame.scripts.domain.generation;

	 public class Map
	 {
		 public int Width { get; set; }
		 public int Height { get; set; }
		 private readonly Cell[,] _map;

		 public Map(Cell[,] map)
		 {
			 Width = map.GetLength(0);
			 Height = map.GetLength(1);
			 _map = map;
		 }

		 public Cell GetCell(int x, int y)
		 {
			 return _map[x, y];
		 }
	 }
