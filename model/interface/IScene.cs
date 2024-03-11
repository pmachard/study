using Math.@interface;
using Model.implem;
using Model.@interface;

namespace Model.@interface
{
    public interface IScene
    {
        // repére origine de la scene
        public ICoordSystem CS { get; set; }
        
        // Ajpoute un objet 3d dans la scene
        public void AddObject(IObject3D o);
        // Nombre d'objet dans la scene
        public int NbrObjects();
        // Retourne l'object 3D a la position précisé
        public IObject3D GetObject(int pos);
        // Supprime un objet de la scene
        public void RemoveObject(IObject3D o);

        public IEnumerator<IObject3D> GetEnumerator();
    }
}