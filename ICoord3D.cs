interface ICoord3d
{
    public ICoord3D();
    public ICoord3D(double x, double y , double z);    
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    static public ICoord3 operator + (ICoord3D a, ICoord3D b) { return a.operator_add(b); }
    static public ICoord3 operator - (ICoord3D a) { return operator_supp(a); }
    static public ICoord3 operator - (ICoord3D a, ICoord3D b) { return a.operator_supp(b); }
    static public ICoord3 operator * (ICoord3D a, ICoord3D b) { return a.operator_mult(b); }
    static public ICoord3 operator * (double m) { return a.operator_mult(m); }
    static public ICoord3 operator / (ICoord3D a, ICoord3D b) { return a.operator_div(b); }
    static public double operator ^ (ICoord3D a, ICoord3D b) { return a.operator_scal(b); }
    static public ICoord3 operator & (ICoord3D a, ICoord3D b) { return a.operator_produit_vect(b); }

    public ICoord3D operator_add(ICoord3D b);
    static public ICoord3D operator_supp(ICoord3D a);
    public ICoord3D operator_supp(ICoord3D b);
    public ICoord3D operator_mult(ICoord3D b);
    public ICoord3D operator_mult(double b);
    public ICoord3D operator_div(ICoord3D b);
    public ICoord3D operator_div(double b);
    public double operator_scal(ICoord3D b);
    public ICoord3D operator_produit_vect(ICoord3D b);
}
