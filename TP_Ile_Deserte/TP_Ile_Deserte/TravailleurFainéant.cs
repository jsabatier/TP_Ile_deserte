using System;
namespace TP_Ile_Deserte
{
    public class TravailleurFaineant : Travailleur
    {
        public TravailleurFaineant(int x, int y):base(x,y)
        {
        }
        public TravailleurFaineant() { }
        /*public override void parcourir(Monde m)
        {
        }
        public override void Construire(Monde m)
        {
            base.Construire(m);
        }*/
        public override string ToString()
        {
            return "(-_-)";
        }
    }
}
