interface IEdge : ITranslatable 
{
  // Bord par default null
  public IEdge ();
  // Bord avec deux points
  public IEdge (ICoord3D a, ICoord3D b);
  
  // Point A du bord
  public ICoord3D A( get; set;);
  // Point B du bord
  public ICoord3D B( get; set;);
}
