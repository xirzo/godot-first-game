using firstgame.scripts.domain.generation;

	public class Room
	{
		public Room[] Neighbours { get; }

		private readonly int _startX;
		private readonly int _startY;
		private readonly int _width;
		private readonly int _height;
		private Cell[,] _cells;
		public Room(int startX, int startY, int width, int height)
		{
			_startX = startX;
			_startY = startY;

			_width = width;
			_height = height;

			_cells = new Cell[_width, _height];

			for (int x = 0; x < _width; x++)
			{
				for (int y = 0; y < _height; y++)
				{
					_cells[x, y] = new Cell(startX + x, startY + y, false);
				}
			}
		}

		public Cell GetCell(int positionX, int positionY)
		{
			return _cells[positionX - _startX, positionY - _startY];
		}

		public Cell[,] GetAllCells()
		{
			return _cells;
		}
	}
