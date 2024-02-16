class SetEdge : ISetEdge
{
    private List<ICoord3D> Coords;
    
    public SetEdge()
    {
        Coords = new List<ICoord3D>();
    }

    public AddPoint(ICoord Pt)
    {
        Coords.Add(Pt);
    }

    public IEnumerator<ICoord3D> GetCoord()
    {
        foreach (ICoord3D coord in Coords) { yield return coord; }
    }
};
