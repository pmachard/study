class Line3D : ILine3D
{
  public Line3D()
  {
    O = new Coord3D();
    V = new Coord3D();    
  }
  
  public ICoord3D O {get; set};
  public ICoord3D V {get; set};

  public bool IsParallel(ILine3D other)
  {    
    return V.IsProportional(other);
  }
  
  public bool IsPerpendicular(ILine3D other)
  {
    produitScalaire = V ^ other.V;
    return produitScalaire == 0.0;
  }

  public bool IsSecant(ILine3D other);
  {    
    return (!other.IsParallel());
  }

  public ICoord3D Intersect(ILine3D other);
  {  
    if ()
    
    return null;
  }
}