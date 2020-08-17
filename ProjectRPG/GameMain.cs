using System;
using System.Collections.Generic;

namespace ProjectRPG
{
    internal class GameMain
    {
        static Random r = new Random();

        public GameMain()
        {
            var enemyList = new List<Enemy>();

            for (int i = 0; i < 100; i++)
            {
                var enemy = new Enemy(r.Next(5, 51), r.Next(1, 10), r.Next(2, 20), randomNev(r.Next(2, 7)));
                enemyList.Add(enemy);
            }

            foreach (var enemy in enemyList)
                Console.WriteLine(enemy);

            Console.ReadLine();
        }

        private static string randomNev(int nevHossz)
        {
            string nev = "";
            string maganHangzok = "AEIOU";
            string massalHangzok = "BCDFGHJKLMNPQRSTVWXYZ";

            string betuVariansANevben = "";

            for (int i = 0; i < nevHossz; i++)
                betuVariansANevben += Convert.ToString(r.Next(0,2));

            foreach (var karakterHely in betuVariansANevben)
            {
                var karakter = karakterHely;

                /*
                if (karakter > 1 || karakter < 0)
                    karakter = '0';
                */

                switch (karakter)
                {
                    case '0':
                        nev += maganHangzok[r.Next(0, maganHangzok.Length)]; break;
                    case '1':
                        nev += massalHangzok[r.Next(0, massalHangzok.Length)]; break;
                    default:
                        break;
                }
            }

            /*
            nev += Convert.ToString(abc[r.Next(1, abc.Length)]).ToUpper();
            for (int i = 0; i < n - 1; i++)
            {
                nev += Convert.ToString(abc[r.Next(0, abc.Length)]).ToLower();
            }
            */

            return nev;
        }
    }
}