using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    class EnemyCreator
    {
        // Ez a script elkészít egy ellenséget adott paraméterek alapján
        public EnemyCreator() { }


        public Enemy makeRandomEnemy(int healthMin, int healthMax, int defMin, int defMax, int atkMin, int atkMax, int nameLenghtMax) 
        {
            var returnEnemy = new Enemy(Globals.r.Next(healthMin, healthMax), Globals.r.Next(defMin, defMax), Globals.r.Next(atkMin, atkMax), randomNev(Globals.r.Next(2, nameLenghtMax)));
            return returnEnemy;
        }

        private static string randomNev(int nevHossz)
        {
            string nev = "";
            string maganHangzok = "AEIOU";
            string massalHangzok = "BCDFGHJKLMNPQRSTVWXYZ";

            string betuVariansANevben = "";

            for (int i = 0; i < nevHossz; i++)
                betuVariansANevben += Convert.ToString(Globals.r.Next(0, 2));

            int karakterSzam = 0;

            foreach (var karakterHely in betuVariansANevben)
            {
                var karakter = karakterHely;

                var karakterMaganhangzo = Convert.ToString(maganHangzok[Globals.r.Next(0, maganHangzok.Length)]);
                var karakterMassalhangzo = Convert.ToString(massalHangzok[Globals.r.Next(0, massalHangzok.Length)]);

                switch (karakter)
                {
                    case '0':
                        if (karakterSzam == 0)
                            nev += karakterMaganhangzo;
                        else
                            nev += karakterMaganhangzo.ToLower();

                        break;
                    case '1':
                        if (karakterSzam == 0)
                            nev += karakterMassalhangzo;
                        else
                            nev += karakterMassalhangzo.ToLower();
                        break;
                    default:
                        break;
                }

                karakterSzam++;
            }

            return nev;
        }

        private static string randomNev2(int nevHossz)
        {
            string abc = "AEIOUBCDFGHJKLMNPQRSTVWXYZ";
            string nev = "";

            nev += Convert.ToString(abc[Globals.r.Next(1, abc.Length)]).ToUpper();
            for (int i = 0; i < nevHossz - 1; i++)
            {
                nev += Convert.ToString(abc[Globals.r.Next(0, abc.Length)]).ToLower();
            }


            return nev;
        }
    }
}
