using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class ControlSpeed
    {
        int speed = 0;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int iSpeed = 4;
        public void ChangeSpeed()
        {
            iSpeed++;
            if (iSpeed > 4)
            {
                iSpeed = 1;
            }
            switch (iSpeed)
            {
                case 1:
                    speed = 400;
                    break;
                case 2:
                    speed = 800;
                    break;
                case 3:
                    speed = 1000;
                    break;
                case 4:
                    speed = 1200;
                    break;
                default:
                    speed = 0;
                    break;
            }
        }
    }
}
