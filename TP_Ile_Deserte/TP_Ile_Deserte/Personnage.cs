using System;
namespace TP_Ile_Deserte
{
    public class Personnage
    {
        protected string Nom { get; set; }
        protected int Posx { get; set; }
        protected int Posy { get; set; }
        protected int TauxEnergie { get; set; }

        private String _nom;
        public Personnage(int x, int y)
        {
            Posx = x;
            Posy = y;
        }
        /*public virtual void parcourir(Monde m)
        {
        }*/
        public Personnage()
        {
        }
    }
}
