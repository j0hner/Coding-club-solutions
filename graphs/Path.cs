readonly struct Path(Vertex end, int weight)
{
    public Vertex EndVert { get; } = end;
    public int Weight { get; } = weight;
}