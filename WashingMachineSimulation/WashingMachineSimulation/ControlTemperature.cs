using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class ControlTemperature
    {
        int temperature = 1;
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public int iTemperature = 4;
        public void ChangeTemperature()
        {
            iTemperature++;
            if (iTemperature > 4)
            {
                iTemperature = 1;
            }
            switch (iTemperature)
            {
                case 1:
                    temperature = 30;
                    break;
                case 2:
                    temperature = 40;
                    break;
                case 3:
                    temperature = 60;
                    break;
                case 4:
                    temperature = 90;
                    break;
                default:
                    temperature = 0;
                    break;
            }
        }
    }
}
