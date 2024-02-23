interface IMatLxC
{
    public int L { get; set;}
    public int C { get; set;}
    public double [,] matrice {get; set;}

    public double IMatLxC colone(c);
    public double IMatLxC ligne(c);

    public double get(int l,int c); 

    // Operateur addition entre deux matrice
    static public IMatLxC operator + (IMatLxC a, IMatLxC b) { return a.operator_add(b); }
    // Operateur d'inversion entre deux matrice
    static public IMatLxC operator - (IMatLxC a) { return operator_supp(a); }
    // Operateur d'affection entre deux matrice
    static public IMatLxC operator - (IMatLxC a, IMatLxC b) { return a.operator_supp(b); }
    // Operateur de multiplication entre deux matrice
    static public IMatLxC operator * (IMatLxC a, IMatLxC b) { return a.operator_mult(b); }
    // Operateur de multiplication entre une matrice et un double
    static public IMatLxC operator * (double m) { return a.operator_mult(m); }
    // Operateur de division entre deux matrice
    static public IMatLxC operator / (IMatLxC a, IMatLxC b) { return a.operator_div(b); }

    // Ajout de deux matrice
    public IMatLxC operator_add(IMatLxC b);
    // Inversion d'une matrice
    static public IMatLxC operator_supp(IMatLxC a);
    // Difference entre deux matrice
    public IMatLxC operator_supp(IMatLxC b);
    // Multiplication entre deux matrice
    public IMatLxC operator_mult(IMatLxC b);
    // Facteur avec une matrice 
    public IMatLxC operator_mult(double b);
    // Division entre deux matrices
    public IMatLxC operator_div(IMatLxC b);
    // Division avec une matrice
    public IMatLxC operator_div(double b);

}
