using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class OrderTimer
    {
        int orderTime = 0;
        public int OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }

        int i = 0;
        public void ChangeTimer()
        {
            i++;
            if(i > 24)
            {
                i = 1;
            }
            orderTime = i;
        }
    }
}
