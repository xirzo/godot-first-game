
	namespace firstgame.scripts.domain.generation;

	public interface IMapGenerator
	{
		int Width { get; }
		int Height { get; }
		Map Generate();
	}
