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

    public RunTranlation(ICoord3D v)
    {
        List<ICoord3D> newList = new List<ICoord3D>();
        foreach (ICoord3D coord in Coords) 
        { 
            newList.Add(coord + v); 
        }
        Coords = newList;
    }
};
