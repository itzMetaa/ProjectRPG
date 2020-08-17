using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    class Enemy
    {
        int hp; //életerő
        int def; //védekezés
        int atk; //támadás
        string name; //név

        public Enemy(int hp, int def, int atk, string name)
        {
            this.hp = hp;
            this.def = def;
            this.atk = atk;
            this.name = name;
        }

        public override string ToString()
        {
            string nevAlahuzas = "";
            for (int i = 0; i < name.Length; i++)
            {
                nevAlahuzas += "_";
            }

            return string.Format("-- {0} --\n" +
                "___{1}___\n\n" +
                "HP: {2}\n" +
                "DEF: {3}\n" +
                "ATK: {4}\n", name, nevAlahuzas, hp, def, atk);
        }
    }
}
