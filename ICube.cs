interface ICube : IObject3D
{
  public ICube();
  public ICube(ICoordSystem coordSystem, double size);

  public ICoordSystem CoSystem {get; set;}
  public double Size(get;set);
}
