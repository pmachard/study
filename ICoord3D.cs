interface ICoord3d
{
    // Création d'une coordonnées avec des valeurs par défault 0.0
    public ICoord3D();
    // Création d'une coordonnées avec des valeurs x,y et z
    public ICoord3D(double x, double y , double z);    
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Operteur addition entre deux coordonnées
    static public ICoord3 operator + (ICoord3D a, ICoord3D b) { return a.operator_add(b); }
    // Operteur d'inversion entre deux coordonnées
    static public ICoord3 operator - (ICoord3D a) { return operator_supp(a); }
    // Operteur d'affection entre deux coordonnées
    static public ICoord3 operator - (ICoord3D a, ICoord3D b) { return a.operator_supp(b); }
    // Operteur de multiplication entre deux coordonnées
    static public ICoord3 operator * (ICoord3D a, ICoord3D b) { return a.operator_mult(b); }
    // Operteur de multiplication entre des coordonnées et un double
    static public ICoord3 operator * (double m) { return a.operator_mult(m); }
    // Operteur de division entre deux coordonnées
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
