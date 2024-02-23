class Cylinder : ICylinder 
{
  public Cylinder()
  {
    LocalCoordSystem = new ICoordSytem();
    Radius = 1.0;
    Height = 1.0;
  }
  public ICylinder(ICoordSystem localCoordSystem, double radius, double height)
  {
    LocalCoordSystem = localCoordSystem;
    Radius = radius;
    Height = height;
  }
  
  public double Radius {get;set;}
  public double Height {get;set;}
  public ICoordSystem LocalCoordSystem {get; set;};

}
