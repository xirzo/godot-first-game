using firstgame.scripts.domain.generation;
using Godot;

namespace firstgame.scripts.view.generation;

public partial class MapView : TileMapLayer
{
	[Export] private Vector2I _floorTilePosition = new(0, 0);
	[Export] private int _tilesetId;
	[Export] private Vector2I _wallTilePosition = new(0, 1);

	private Map _map;

	public void Construct(Map map)
	{
		_map = map;
	}

	public void Render()
	{
		for (var x = 0; x < _map.Width; x++)
			for (var y = 0; y < _map.Height; y++)
			{
				var position = new Vector2I(x, y);
				if (_map.GetCell(x, y).IsSolid)
				{
					SetCell(position, _tilesetId, _wallTilePosition);
					continue;
				}

				SetCell(position, _tilesetId, _floorTilePosition);
			}
	}
}