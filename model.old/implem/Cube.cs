class Cube : ICube
{
  public Cube()
  {
    LocalCoordSystem = new CoordSytem();
    Size = 1.0;
  }
  
  public ICube(ICoordSystem coordSystem, double size)
  {
    LocalCoordSystem = coordSytem;
    Size = size;
  }

  public ICoordSystem LocalCoordSystem {get; set;};
  public double Size(get;set);
  
  public RunTranlation(ICoord3D v)
  {
      coordSystem.RunTranslation(v);
  }
}
