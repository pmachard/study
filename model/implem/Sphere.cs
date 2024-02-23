interface Sphere : ISphere
{
  public Sphere()
  {
    LocalCoordSystem = new CoordSystem ();
    Radius = 1.0;
  }
  
  public Sphere(ICoordSystem cs, double r)
  {
    LocalCoordSystem = cs;
    Radius = r;
  }

  public double Radius(get;set);
  public ICoordSystem LocalCoordSystem {get; set;};
  
  public RunTranlation(ICoord3D v)
  {
      coordSystem.RunTranslation(v);
  }
}
