using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    class Player
    {
        int lvl; //szint
        int exp; //szint xp
        int expUp; //szint xp ami a szintlépéshez kell
        int hp; //életerő
        int def; //védekezés
        int atk; //támadás
        string name; //név

        public Player(int lvl, int exp, int expUp, int hp, int def, int atk, string name)
        {
            this.lvl = lvl;
            this.exp = exp;
            this.expUp = expUp;
            this.hp = hp;
            this.def = def;
            this.atk = atk;
            this.name = name;
        }

        public int Lvl { get => lvl; set => lvl = value; }
        public int Exp { get => exp; set => exp = value; }
        public int ExpUp { get => expUp; set => expUp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Def { get => def; set => def = value; }
        public int Atk { get => atk; set => atk = value; }
        public string Name { get => name; set => name = value; }
    }
}
