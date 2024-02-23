interface IMat
{
    public int N { get; set;}
    public int M { get; set;}

    public double get(int n,int m); 

    // Operateur addition entre deux matrice
    static public IMat operator + (IMat a, IMat b) { return a.operator_add(b); }
    // Operateur d'inversion entre deux matrice
    static public IMat operator - (IMat a) { return operator_supp(a); }
    // Operateur d'affection entre deux matrices
    static public IMat operator - (IMat a, IMat b) { return a.operator_supp(b); }
    // Operateur de multiplication entre deux matrices
    static public IMat operator * (IMat a, IMat b) { return a.operator_mult(b); }
    // Operateur de multiplication entre une matrice et un double
    static public ICoord3 operator * (double m) { return a.operator_mult(m); }
    // Operateur de division entre deux matrices
    static public IMat operator / (IMat a, IMat b) { return a.operator_div(b); }

    // Ajout de matrices
    public IMat operator_add(IMat b);
    // Inversion de matrice
    static public IMat operator_supp(IMat a);
    // Difference entre deux matrices 
    public IMat operator_supp(IMat b);
    // Multiplication entre deux matrices
    public IMat operator_mult(IMat b);
    // Facteur avec une matrices
    public IMat operator_mult(double b);
    // Division entre deux matrices 
    public IMat operator_div(IMat b);
    // Division avec une matrices 
    public IMat operator_div(double b);

}