interface IEdge
{
  public IEdge ();
  public IEdge (ICoord3D a, ICoord3D b);
  
  public ICoord3D A( get; set;);
  public ICoord3D B( get; set;);
}
