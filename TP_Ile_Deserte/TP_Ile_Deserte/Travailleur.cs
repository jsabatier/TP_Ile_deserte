using System;
namespace TP_Ile_Deserte
{
    public class Travailleur : Personnage
    {
        public Travailleur(int x, int y):base(x,y)
        {
        }
        public Travailleur() { }
        /*public override void parcourir(Monde m)
        {
        }
        public virtual void Construire(Monde m)
        {
            
        }*/
        public override string ToString()
        {
            return "(._.)";
        }
    }
}
