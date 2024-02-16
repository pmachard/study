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
  
};
