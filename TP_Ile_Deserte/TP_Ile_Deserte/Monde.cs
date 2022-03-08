using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Ile_Deserte
{
    class Monde
    {
        private int _nbL, _nbC;
        private string[,] _monde;
        private string[,] _batiment;
        // private List<Personnage> _listePerso;

        public Monde()
        {
            _nbC = 10;
            _nbL = 10;
            this.initialiseMonde();
            _listePerso = new List<Personnage>();
            this.genereListePerso();
        }

        public void Parcourir()
        {
            for (int i = 0; i < _listePerso.Count; i++)
            {
                _listePerso[i].parcourir(this);
            }
        }

        public void genereListePerso()
        {
            Random r = new Random();
            int posX = r.Next(0, _nbC);
            int posY = r.Next(0, _nbL);
            _listePerso.Add(new Travailleur(posX, posY));
            posX = r.Next(0, _nbC);
            posY = r.Next(0, _nbL);
            _listePerso.Add(new Travailleur(posX, posY));
            posX = r.Next(0, _nbC);
            posY = r.Next(0, _nbL);
            _listePerso.Add(new Enfant (posX, posY));
            posX = r.Next(0, _nbC);
            posY = r.Next(0, _nbL);
            _listePerso.Add(new Chat (posX, posY));

        }

        public void ajoutePerso(Personnage p)
        {
            _listePerso.Add(p);
        }
        public void supprimerPerso (Personnage p)
        {
            _listePerso.Delete(p);
        }

        public void initialiseMonde()
        {
            _monde = new string[_nbL, _nbC] { {"E","E","E","E","E", "E", "E", "E", "E", "E"},
                                            { "E", "E", "E", "P", "P", "P", "P", "E", "E", "E" },
                                            { "E", "E", "P", "H", "H", "H", "H", "P", "E", "E" },
                                            { "E", "P", "H", "F", "F", "F", "F", "H", "P", "E" },
                                            { "E", "P", "H", "F", "F", "F", "F", "H", "P", "E" },
                                            { "E", "P", "H", "F", "F", "F", "F", "H", "P", "E" },
                                            { "E", "P", "H", "F", "F", "F", "F", "H", "P", "E" },
                                            { "E", "E", "P", "H", "H", "H", "H", "P", "E", "E" },
                                            { "E", "E", "E", "P", "P", "P", "P", "E", "E", "E" },
                                            { "E", "E", "E", "E", "E", "E", "E", "E", "E", "E" }};
            // mettre des P,F,B et E
        }
        
        public void metBatiment (int posX, int posY)
        {
            // hutte que sur la plage 
            if ( ressource)
            {
                _batiment[posX, posY] = "Hutte";
            }
            // puits/ arbre à chat forets
            // aire de loisirs eau
        }

        public override string ToString()
        {
            string description = "";
            description = description+"*************************************************************");
            description = description + "Etat de l'île : \n";
            description = description + "\t Personnages : \n ";
            foreach (Personnage p in _listePerso)
            {
               description= description+"\t Nom : \n"+ p.Nom + "\t Fonction : \n" + ...+"\t Energie : \n" + p.TauxEnergie;
            }
            Console.WriteLine("*************************************************************");
            return base.ToString();
        }






































































































































































































































































































































































































































































































    }
}
