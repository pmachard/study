class Cube : ICube
{
  public Cube()
  {
    Size = 1.0;
    LocalCoordSystem = new CoordSytem();
  }
  
  public ICube(ICoordSystem coordSystem, double size)
  {
    Size = size;
    LocalCoordSystem = coordSytem;
  }

  public double Size(get;set);
  public ICoordSystem LocalCoordSystem {get; set;};
  
  public RunTranlation(ICoord3D v)
  {
      coordSystem.RunTranslation(v);
  }
}
