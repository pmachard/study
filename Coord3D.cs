class Coord3D : ICoord3d
{
    public Coord3D()
    {
        X = Y = Z = 0.0;
    }
    
    public Coord3D(double x, double y , double z)
    {
        X = x; Y = y; Z = z;
    }
    
    public ICoord3D operator_add(ICoord3D b)
    {
        return new Coord3D ( this.X + b.X, this.Y + b.Y, this.Z + b.Z );
    }
    
    static public ICoord3D operator_supp(ICoord3D a)
    {
        return new Coord3D ( this.X - b.X, this.Y - b.Y, this.Z - b.Z );
    }
    
    public ICoord3D operator_supp(ICoord3D b)
    {
        return new Coord3D ( - b.X, - b.Y, - b.Z);
    }
    
    public ICoord3D operator_mult(ICoord3D b)
    {
        return new Coord3D ( this.X * b.X, this.Y * b.Y, this.Z * b.Z);
    }

    public ICoord3D operator_mult(double b)
    {
        return new Coord3D ( this.X * b, this.Y * b, this.Z * b);
    }

    public ICoord3D operator_div(ICoord3D b)
    {
        return new Coord3D ( this.X / b.X, this.Y / b.Y, this.Z / b.Z);    
    }
    
    public ICoord3D operator_div(double b)
    {
        return new Coord3D ( this.X / b, this.Y / b, this.Z / b);    
    }

    public double operator_scal(ICoord3D b)
    {
        return this.X / b.X + this.Y / b.Y + this.Z / b.Z;    
    }

    public ICoord3d operator_produit_vect(ICoord3D b)
    {
        return new Coord3D ( this.Y*b.Z - this.Z*b.Y, this.Z*b.X - this.X*b.Z, this.X*b.Y - this.Y*b.X );    
    }

    public bool IsProportional(other)
    {
        if (other.X == 0.0) && (X !== 0)
            return false;
        if (other.Y == 0.0) && (Y !== 0)
            return false;
        if (other.Z == 0.0) && (Z !== 0)
            return false;
            
        double (other.X != 0.0) ? tx = X / other.X : 0.0;
        double (other.Y != 0.0) ? ty = Y / other.Y : 0.0;
        double (other.Z != 0.0) ? tz = Z / other.Z : 0.0;
        if (tx == ty) && (ty == tz )) && ( tz == 0.0)
            return true;
        if (tx == 0.0)
            return (ty == tz) ;
        if (ty == 0.0)
            return (tx == tz) ;
        if (tz == 0.0)
            return (tx == ty) ;
        if (tx == ty) && (tx = 0.0)
            return true;            
        if (tx == tz) && (tz = 0.0)
            return true;
        if (ty == tz) && (tz = 0.0)
            return true;
        
        return (tx == ty) && (tx == tz) ;
    }

    public ICoord3D swap()
    {
        return new Coord3D( this.Z, this.Y, this.X);
    }
};
