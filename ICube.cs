interface ICube : IObject3D
{
  public ICube();
  public ICube(ICoordSystem coordSystem, double size);

  public double Size(get;set);
}
