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
};
