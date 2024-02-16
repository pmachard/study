class Cube : ICube
{
  public Cube()
  {
    Size = 0.0;
    coordSystem = new CoordSytem();
  }
  
  public ICube(ICoordSystem coordSystem, double size)
  {
  }

  public double Size(get;set);
  public ICoordSystem coordSystem {get; set;};
  
  public RunTranlation(ICoord3D v)
  {
      coordSystem.RunTranslation(v);
  }

}
