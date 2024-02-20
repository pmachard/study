interface ILine3D
{
  public ICoord3D O {get; set};
  public ICoord3D V {get; set};

  public bool IsParallel();
  public bool IsPerpendicular();
  public bool IsSecant();

  public ICoord3D Intersect(ILine3D other);
}
