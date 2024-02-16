class Cylinder : ICylinder 
{
  public Cylinder()
  {
    Radius = 1.0;
    Height = 1.0;
    LocalCoordSystem = new ICoordSytem();
  }
  public ICylinder(ICoordSystem localCoordSystem, double radius, double height)
  {
    Radius = radius;
    Height = height;
    LocalCoordSystem = localCoordSystem;
  }
  
  public double Radius {get;set;}
  public double Height {get;set;}
  public ICoordSystem LocalCoordSystem {get; set;};

}
