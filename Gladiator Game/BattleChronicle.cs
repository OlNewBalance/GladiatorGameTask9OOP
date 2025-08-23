using System;
using System.Collections.Generic;

namespace Gladiator_Game
{
    public class BattleChronicle
    {
        public readonly List<string> battleLog = new List<string>();
        private int turnCounter = 0;

        public void LogAction(string action)
        {
            turnCounter++;
            battleLog.Add($"{turnCounter}. {action}");
        }
    }
}
