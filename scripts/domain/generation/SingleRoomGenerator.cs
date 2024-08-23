namespace firstgame.scripts.domain.generation;

public class SingleRoomGenerator : IMapGenerator
{
    public SingleRoomGenerator(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Width { get; }
    public int Height { get; }

    public Map Generate()
    {
        var cells = new Cell[Width, Height];

        for (var x = 0; x < Width; x++)
        for (var y = 0; y < Height; y++)
        {
            if (x == 0 || y == 0 || x == Width - 1 || y == Height - 1)
            {
                cells[x, y] = new Cell(x, y, true);
                continue;
            }

            cells[x, y] = new Cell(x, y, false);
        }

        return new Map(cells);
    }
}