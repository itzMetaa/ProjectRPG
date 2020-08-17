using System;

namespace ProjectRPG
{
    internal class PlayerIntroductionSegment
    {
        public PlayerIntroductionSegment()
        {
            bool playerNameSet = false;
            string playerName = "";
            while (!playerNameSet)
            {
                try
                {
                    Console.Clear();
                    Console.Write("What's your name?: ");
                    playerName = Console.ReadLine();
                    playerNameSet = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Player name is not valid!\n\nPress enter to continue..");
                    playerNameSet = false;
                }
            }
            
            Globals.player = new Player(1,0,100,50,5,10,playerName);

        }
    }
}