using System;
namespace TP_Ile_Deserte
{
    public class Enfant : Personnage
    {
        public Enfant(int x, int y):base()
        {
        }
        public Enfant()
        {

        }
        /*public override void parcourir(Monde m)
        {
        }
        public void Explorer(Monde m)
        {

        }*/
        public override string ToString()
        {
            return "(o_o)";
        }
    }
}
