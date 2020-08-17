using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    static class Globals 
    {
        public static Random r = new Random();
        public static Player player;

        public static int[] enemyScaler = new int[7];

        public static int enemyHealthMinScaler = 0;
        public static int enemyHealthMaxScaler = 0;
        public static int enemyDefenseMinScaler = 0;
        public static int enemyDefenseMaxScaler = 0;
        public static int enemyAttackMinScaler = 0;
        public static int enemyAttackMaxScaler = 0;
        public static int enemyNameLength = Globals.r.Next(1, 9);
    }

    class Program
    {

        static void Main(string[] args)
        {
            var game = new GameMain();

        }
    }
}
