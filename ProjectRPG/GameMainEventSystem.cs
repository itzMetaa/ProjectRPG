using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRPG
{
    class GameMainEventSystem
    {
        //ez a script tárolja a történéseket a játék során
        public GameMainEventSystem() 
        {
            var playerIntroductor = new PlayerIntroductionSegment();




            var enemyList = new List<Enemy>();
            var enemyCreator = new EnemyCreator();


            

            for (int i = 0; i < 20; i++)
            {
                var enemy = enemyCreator.makeRandomEnemy(enemyHealthMinScaler, enemyHealthMaxScaler, enemyDefenseMinScaler, enemyDefenseMaxScaler, enemyAttackMinScaler, enemyAttackMaxScaler, enemyNameLength);
                enemyList.Add(enemy);
            }

            foreach (var enemy in enemyList)
                Console.WriteLine(enemy);

            Console.ReadLine();
        }
    }
}
