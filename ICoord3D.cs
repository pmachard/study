interface ICoord3d
{
    // Création d'une coordonnées avec des valeurs par défault 0.0
    public ICoord3D();
    // Création d'une coordonnées avec des valeurs x,y et z
    public ICoord3D(double x, double y , double z);    
    
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    // Operateur addition entre deux coordonnées
    static public ICoord3 operator + (ICoord3D a, ICoord3D b) { return a.operator_add(b); }
    // Operateur d'inversion entre deux coordonnées
    static public ICoord3 operator - (ICoord3D a) { return operator_supp(a); }
    // Operateur d'affection entre deux coordonnées
    static public ICoord3 operator - (ICoord3D a, ICoord3D b) { return a.operator_supp(b); }
    // Operateur de multiplication entre deux coordonnées
    static public ICoord3 operator * (ICoord3D a, ICoord3D b) { return a.operator_mult(b); }
    // Operateur de multiplication entre des coordonnées et un double
    static public ICoord3 operator * (double m) { return a.operator_mult(m); }
    // Operateur de division entre deux coordonnées
    static public ICoord3 operator / (ICoord3D a, ICoord3D b) { return a.operator_div(b); }
    // Operateur produit scalaire entre deux coordonnées
    static public double operator ^ (ICoord3D a, ICoord3D b) { return a.operator_scal(b); }
    // Operator produit vectoriel entre deux coordonnées
    static public ICoord3 operator & (ICoord3D a, ICoord3D b) { return a.operator_produit_vect(b); }

    // Ajout de coodonnées
    public ICoord3D operator_add(ICoord3D b);
    // Inversion de coodonnées
    static public ICoord3D operator_supp(ICoord3D a);
    // Difference entre deux coordonnées
    public ICoord3D operator_supp(ICoord3D b);
    // Multiplication entre deux coordonnées
    public ICoord3D operator_mult(ICoord3D b);
    // Facteur avec des coordonnées
    public ICoord3D operator_mult(double b);
    // Division entre deux coordonnées
    public ICoord3D operator_div(ICoord3D b);
    // Division avec des coordonnées
    public ICoord3D operator_div(double b);
    // Produit scalaire entre deux coordonnées
    public double operator_scal(ICoord3D b);
    // Produit vectoriel entre deux vecteur
    public ICoord3D operator_produit_vect(ICoord3D b);

    // Swap des valeurs (x=z,y=y,z=x) 
    public ICoord3D swap();
    
}
