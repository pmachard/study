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

        public IInterPoint Compute(IScene scene, IRay ray);
        public IInterPoint Compute(IRay ray);

        public IColor Compute(IScene scene, IRay ray, IInterPoint closerPoint);

    }
}
