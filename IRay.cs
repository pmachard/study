interface IRay : IObject3D
{
  public IRay();
  public IRay(ICoord3D o, ICoord3D v);

  public ICoord3D O { get; set; };
  public ICoord3D V { get; set; };

  

}
