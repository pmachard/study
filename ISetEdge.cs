interface ISetEdge : ITranslatable
{
    public ISetEdge();

    public AddPoint(ICoord Pt);
    
    public IEnumerator<ICoord3D> GetCoord();
};
