namespace Math.@interface
{
    public interface ICoord3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Operateur addition entre deux coordonnées
        static public ICoord3D operator +(ICoord3D a, ICoord3D b) { return a.operator_add(b); }
        // Operateur d'inversion entre deux coordonnées
        static public ICoord3D operator -(ICoord3D a) { return a.operator_supp(); }
        // Operateur d'affection entre deux coordonnées
        static public ICoord3D operator -(ICoord3D a, ICoord3D b) { return a.operator_supp(b); }
        // Operateur de multiplication entre deux coordonnées
        static public ICoord3D operator *(ICoord3D a, ICoord3D b) { return a.operator_mult(b); }
        // Operateur de multiplication entre des coordonnées et un double
        static public ICoord3D operator *(ICoord3D a, double m) { return a.operator_mult(m); }
        // Operateur de division entre deux coordonnées
        static public ICoord3D operator /(ICoord3D a, ICoord3D b) { return a.operator_div(b); }
        // Operateur de division entre une matrice et un double
        static public ICoord3D operator /(ICoord3D a, double d) { return a.operator_div(d); }
        // Operateur produit scalaire entre deux coordonnées
        static public double operator ^(ICoord3D a, ICoord3D b) { return a.operator_scal(b); }
        // Operator produit vectoriel entre deux coordonnées
        static public ICoord3D operator &(ICoord3D a, ICoord3D b) { return a.operator_produit_vect(b); }

        // Ajout de coodonnées
        public ICoord3D operator_add(ICoord3D b);
        // Inversion de coodonnées
        public ICoord3D operator_supp();
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

        // vérifie que les deux coords sont propotionel
        public bool IsProportional(ICoord3D other);

        // Swap des valeurs (x=z,y=y,z=x) 
        public ICoord3D swap();

    }

}