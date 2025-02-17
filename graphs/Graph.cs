static class Graph{
    public static List<Vertex> Bfs(Vertex start) {
        List<Vertex> output = new(); // found vertexes
 
        Stack<Vertex> queue = new(); // vertexes to be procesed
 
        queue.Push(start);
 
        while (!(queue.Count == 0)) {
            Vertex currentVertex = queue.Pop();
 
            output.Add(currentVertex);
 
            foreach (Path path in currentVertex.Paths) {
                if (!output.Contains(path.EndVert) && !queue.Contains(path.EndVert)) {
                    queue.Push(path.EndVert);
                }
            }
        }
        return output;
    }

    public static List<Vertex> Dfs(Vertex start) {
        List<Vertex> output = []; // found vertexes

        void search(Vertex vert){
            if (!output.Contains(vert)) output.Add(vert);

            foreach (Path path in vert.Paths) {
                if (output.Contains(path.EndVert)) continue;
                search(path.EndVert);
            }
        }

        search(start);

        return output;
    }
}