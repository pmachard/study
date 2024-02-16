interface IEdge : ITranslatable 
{
  public IEdge ();
  public IEdge (ICoord3D a, ICoord3D b);
  
  public ICoord3D A( get; set;);
  public ICoord3D B( get; set;);

    public RunTranlation(ICoord3D v)
    {
        A = A + v;
        B = B + v;
    }
}
