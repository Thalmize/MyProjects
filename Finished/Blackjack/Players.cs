using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Players
    {
        public Players() { }

        public void CPUPlaying()
        {
            switch(Information.Variables.Player.PlayerSeat)
            {
                case 1:
                    Information.Variables.CPU.CPUActive[1] = 2;
                    Information.Variables.CPU.CPUActive[2] = 3;
                    Information.Variables.CPU.CPUActive[3] = 4;
                    Information.Variables.CPU.CPUActive[4] = 5;
                    Information.Variables.CPU.CPUActive[5] = 6;
                    break;
                case 2:
                    Information.Variables.CPU.CPUActive[1] = 1;
                    Information.Variables.CPU.CPUActive[2] = 3;
                    Information.Variables.CPU.CPUActive[3] = 4;
                    Information.Variables.CPU.CPUActive[4] = 5;
                    Information.Variables.CPU.CPUActive[5] = 6;
                    break;
                case 3:
                    Information.Variables.CPU.CPUActive[1] = 1;
                    Information.Variables.CPU.CPUActive[2] = 2;
                    Information.Variables.CPU.CPUActive[3] = 4;
                    Information.Variables.CPU.CPUActive[4] = 5;
                    Information.Variables.CPU.CPUActive[5] = 6;
                    break;
                case 4:
                    Information.Variables.CPU.CPUActive[1] = 1;
                    Information.Variables.CPU.CPUActive[2] = 2;
                    Information.Variables.CPU.CPUActive[3] = 3;
                    Information.Variables.CPU.CPUActive[4] = 5;
                    Information.Variables.CPU.CPUActive[5] = 6;
                    break;
                case 5:
                    Information.Variables.CPU.CPUActive[1] = 1;
                    Information.Variables.CPU.CPUActive[2] = 2;
                    Information.Variables.CPU.CPUActive[3] = 3;
                    Information.Variables.CPU.CPUActive[4] = 4;
                    Information.Variables.CPU.CPUActive[5] = 6;
                    break;
                case 6:
                    Information.Variables.CPU.CPUActive[1] = 1;
                    Information.Variables.CPU.CPUActive[2] = 2;
                    Information.Variables.CPU.CPUActive[3] = 3;
                    Information.Variables.CPU.CPUActive[4] = 4;
                    Information.Variables.CPU.CPUActive[5] = 5;
                    break;
            }
        }
    }
}
