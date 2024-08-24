namespace firstgame.scripts.domain.generation.RoomStyleGeneration;

public class RoomStyleGenerator : IMapGenerator
{
	private readonly RoomGenerator _roomGenerator;
	private readonly int _numberOfRooms;
	private Room[] _rooms;

	public RoomStyleGenerator(int numberOfRooms)
	{
		_numberOfRooms = numberOfRooms;
		_roomGenerator = new RoomGenerator(3, 10, 5, 15, _numberOfRooms);
	}

	public int Width { get; }

	public int Height { get; }

	public Map Generate()
	{
		_roomGenerator.Generate(0, 0);

		var cells = new Cell[_roomGenerator.MaxMapWidth, _roomGenerator.MaxMapHeight];

		ConvertRoomsToCells(cells);

		return new Map(cells);
	}

	private void ConvertRoomsToCells(Cell[,] cells)
	{
		for (var i = 0; i < _roomGenerator.Rooms.Count; i++)
		{
			var roomCells = _roomGenerator.Rooms[i].GetAllCells();

			for (var x = 0; x < roomCells.GetLength(0); x++)
				for (var y = 0; y < roomCells.GetLength(1); y++)
					cells[roomCells[x, y].X, roomCells[x, y].Y] = roomCells[x, y];
		}
	}
}
