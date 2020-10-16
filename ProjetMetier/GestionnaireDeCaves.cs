using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            // A vous de jouer
            lesCaves.Add(unNomDeCave,lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            // A vous de jouer

            return lesCaves[unNomDeCave].Count;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer
            int nbVin = 0;
            foreach (Bouteille b in lesCaves[unNomDeCave])
            {
                if (b.LeVin.LaCouleur.NomCouleur.CompareTo("Rouges") == 0)
                {
                    nbVin++;
                }
            }
            return nbVin;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer
            double prix = 0;
            foreach (Bouteille b in lesCaves[unNomDeCave])
            {
                prix = b.QuantiteBouteille * b.LeVin.PrixDuVin;
            }
            return prix;
            
        }
    }
}
