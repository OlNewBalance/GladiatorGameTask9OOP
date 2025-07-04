using System;
using System.Collections.Generic;

namespace Gladiator_Game
{
    public class BattleChronicle
    {
        public static readonly List<string> battleLog = new List<string>();
        private static int turnCounter = 0;

        public static void LogAction(string action)
        {
            turnCounter++;
            battleLog.Add($"{turnCounter}. {action}");
        }
    }
}
