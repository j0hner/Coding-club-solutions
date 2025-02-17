internal class Program{

    /*current graph layout
    *
    *       2── D
    *      ╱    |
    *     ╱     3
    *    ╱      |
    *   A ──9─> B ──5── C
    *
    *   E ──2── F
    *
    *   ─── = both way connection
    *   ──> = one way connection
    */

    public static void Main(string[] args)
    {
        Vertex a = new("A");
        Vertex b = new("B");
        Vertex c = new("C");
        Vertex d = new("D");
        Vertex e = new("E");
        Vertex f = new("F");

        a.Paths.Add(new Path(b, 9));
        a.Paths.Add(new Path(d, 2));
 
        b.Paths.Add(new Path(c, 5));
        b.Paths.Add(new Path(d, 3));
 
        c.Paths.Add(new Path(b, 5));
 
        d.Paths.Add(new Path(a, 2));
        d.Paths.Add(new Path(b, 3));
 
        e.Paths.Add(new Path(f, 2));
        f.Paths.Add(new Path(e, 2));

        foreach (Vertex vert in Graph.Dfs(a)){
            Console.WriteLine(vert);
        }
    }
}