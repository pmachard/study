interface ICoord3d
{
    public ICoord3D();
    public ICoord3D(double x, double y , double z);    
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    static public ICoord3 operator + (ICoord3D a, ICoord3D b) { return a.operator_add(b); }
    static public ICoord3 operator - (ICoord3D a, ICoord3D b) { return a.operator_supp(b); }
    static public ICoord3 operator * (ICoord3D a, ICoord3D b) { return a.operator_mult(b); }
    static public ICoord3 operator / (ICoord3D a, ICoord3D b) { return a.operator_div(b); }

    public operator_add(ICoord3D b);
    public operator_supp(ICoord3D b);
    public operator_mult(ICoord3D b);
    public operator_div(ICoord3D b);
    
}
