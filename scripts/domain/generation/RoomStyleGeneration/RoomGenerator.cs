using System;
using System.Collections.Generic;

	public class RoomGenerator
	{
		public int MaxMapWidth { get; private set; }
		public int MaxMapHeight { get; private set; }
		public IReadOnlyList<Room> Rooms => _rooms.AsReadOnly();
		private readonly int _minRoomWidth;
		private readonly int _maxRoomWidth;
		private readonly int _minRoomHeight;
		private readonly int _maxRoomHeight;
		private int _numberOfRooms;
		private List<Room> _rooms;
		private Random _random = new Random();

		public RoomGenerator(int minRoomWidth, int maxRoomWidth, int minRoomHeight, int maxRoomHeight, int numberOfRooms)
		{
			_minRoomWidth = minRoomWidth;
			_maxRoomWidth = maxRoomWidth;

			_minRoomHeight = minRoomHeight;
			_maxRoomHeight = maxRoomHeight;

			MaxMapWidth = 100;
			MaxMapHeight = 100;

			_numberOfRooms = numberOfRooms;

			_rooms = new List<Room>();
		}

		private void ShuffleDirection()
		{

		}

		private void GenerateRoom(int x, int y)
		{
			int width = _random.Next(_minRoomWidth, _maxRoomWidth);
			int height = _random.Next(_minRoomHeight, _maxRoomHeight);

			Room room = new Room(x, y, width, height);
			_rooms.Add(room);

			_numberOfRooms -= 1;
		}

		public void Generate(int x, int y)
		{
			GenerateRoom(x, y);

			// Change x and y here

			x += 10;

			if (_numberOfRooms > 0)
				Generate(x, y);
		}
	}
