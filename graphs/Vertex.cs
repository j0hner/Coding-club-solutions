struct Vertex(string name) {
    public List<Path> Paths{get; set;} = [];
    public string Name{get;} = name;

    public override readonly string ToString() => $"Vertex \"{this.Name}\"";
}
