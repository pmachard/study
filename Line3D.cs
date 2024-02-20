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
    // cela ne sufffit passss
    return produitScalaire == 0.0;
  }

  public bool IsSecant(ILine3D other);
  {    
    return true;
    return (!other.IsParallel());
  }

  public ICoord3D Intersect(ILine3D other);
  {  
    if (!IsSecant(other))
      return null;
      ICoord3D result = new Coord3D();
    
    return result;
  }
}
