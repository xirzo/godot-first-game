using firstgame.scripts.domain.generation;
using firstgame.scripts.view.generation;
using Godot;

namespace firstgame.scripts.initialization;

public partial class GeneratorInitializer : Node
{
	private Map _map;
	private IMapGenerator _mapGenerator;
	private MapView _mapView;
	[Export] private PackedScene _mapViewScene;

	private void Initialize()
	{
		_mapGenerator = new SingleRoomGenerator(20, 10);
	}

	private void Generate()
	{
		_map = _mapGenerator.Generate();
		_mapView = (MapView)_mapViewScene.Instantiate();
		AddChild(_mapView);
		_mapView.Construct(_map);
		_mapView.Render();
	}

	public override void _Ready()
	{
		Initialize();
		Generate();
	}
}
