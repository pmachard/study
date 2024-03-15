using Math.@interface;
using Model.nterface;

namespace Model.@interface
{
    public interface IObject3D : ITranslatable
    {
        // repere local de l'object 3d
        public ICoordSystem CS { get; set; }
        // nom de l'objet 3d
        public string Name { get; set; }
        // recupere la hit box de l'objet 3D
        public IHitBox GetHitBox();
        // Calcul l'intersection entre l'objet et un rayon 
        public IInterPoint Compute(IRay ray);
    }
}
