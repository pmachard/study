namespace Math.@interface
{
    public interface ICoordSystem
    {

        // Centre du repère
        public ICoord3D O { get; set; }
        // Vecteur X
        public ICoord3D I { get; set; }
        // Vecteur Y
        public ICoord3D J { get; set; }
        // Vecteur Z
        public ICoord3D K { get; set; }
        // vérifie la normalité du repère 
        public bool IsNormal();
    }
}