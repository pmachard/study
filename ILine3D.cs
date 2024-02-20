interface ILine3D
{
  public ICoord3D O {get; set};
  public ICoord3D V {get; set};

  public bool IsParallel(ILine3D other);
  public bool IsPerpendicular(ILine3D other);
  public bool IsSecant(ILine3D other);

  public ICoord3D Intersect(ILine3D other);
}
