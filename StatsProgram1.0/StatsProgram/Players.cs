using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsProgram
{
    class Players : Teams
    {
        private string playerTeam;
        private char playerPosition;
        private byte playerNumber;
        private string playerFirstName;
        private string playerLastName;
        private byte playerAge;
        public Players() { }

        public Players(string playerT, char playerPos, byte playerNum, string playerFN, string playerLN, byte playerA)
        {
            this.playerTeam = playerT;
            this.playerPosition = playerPos;
            this.playerNumber = playerNum;
            this.playerFirstName = playerFN;
            this.playerLastName = playerLN;
            this.playerAge = playerA;
            RosterCount++;
        }
        
    }
}
