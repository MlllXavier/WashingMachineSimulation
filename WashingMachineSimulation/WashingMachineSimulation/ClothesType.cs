using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class ClothesType
    {
        public int temperature;//温度
        public int cleanWashTime;//净洗时间
        public int cleanWashSpeed;//净洗速度
        public int rinseTimes;//漂洗次数
        public int rinseTime;//漂洗时间
        public int rinseSpeed;//漂洗速度
        public int dryTime;//脱水时间
        public int drySpeed;//脱水速度

        public int TotleTime()
        {
            return cleanWashTime + rinseTime * rinseTimes + dryTime + 16 * (rinseTimes + 1);//考虑进水出水时间
        }

        public ClothesType(int i)
        {
            switch (i)
            {
                case 6://速洗15'
                    temperature = 0;
                    cleanWashTime = 8;
                    cleanWashSpeed = 600;
                    rinseTimes = 1;
                    rinseTime = 4;
                    rinseSpeed = 600;
                    dryTime = 3;
                    drySpeed = 1400;
                    break;
                case 7://大件/牛仔
                    temperature = 30;
                    cleanWashTime = 80;
                    cleanWashSpeed = 800;
                    rinseTimes = 1;
                    rinseTime = 8;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 1200;
                    break;
                case 8://混合
                    temperature = 30;
                    cleanWashTime = 67;
                    cleanWashSpeed = 800;
                    rinseTimes = 2;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 1200;
                    break;
                case 9://休闲装
                    temperature = 30;
                    cleanWashTime = 56;
                    cleanWashSpeed = 600;
                    rinseTimes = 1;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 800;
                    break;
                case 10://漂洗加脱水
                    temperature = 0;
                    cleanWashTime = 0;
                    cleanWashSpeed = 0;
                    rinseTimes = 2;
                    rinseTime = 26;
                    rinseSpeed = 600;
                    dryTime = 7;
                    drySpeed = 1200;
                    break;
                case 11://单脱水
                    temperature = 0;
                    cleanWashTime = 0;
                    cleanWashSpeed = 0;
                    rinseTimes = 0;
                    rinseTime = 0;
                    rinseSpeed = 0;
                    dryTime = 7;
                    drySpeed = 1200;
                    break;
                case 1://筒自洁
                    temperature = 90;
                    cleanWashTime = 60;
                    cleanWashSpeed = 600;
                    rinseTimes = 2;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 3;
                    drySpeed = 600;
                    break;
                case 2://羽绒
                    temperature = 30;
                    cleanWashTime = 67;
                    cleanWashSpeed = 600;
                    rinseTimes = 3;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 0;
                    drySpeed = 0;
                    break;
                case 3://超柔
                    temperature = 30;
                    cleanWashTime = 41;
                    cleanWashSpeed = 600;
                    rinseTimes = 2;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 600;
                    break;
                case 4://内衣
                    temperature = 30;
                    cleanWashTime = 63;
                    cleanWashSpeed = 600;
                    rinseTimes = 2;
                    rinseTime = 10;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 800;
                    break;
                case 5://棉麻
                    temperature = 30;
                    cleanWashTime = 67;
                    cleanWashSpeed = 600;
                    rinseTimes = 2;
                    rinseTime = 15;
                    rinseSpeed = 600;
                    dryTime = 6;
                    drySpeed = 600;
                    break;
                default:
                    temperature = 0;
                    cleanWashTime = 0;
                    cleanWashSpeed = 0;
                    rinseTimes = 0;
                    rinseTime = 0;
                    rinseSpeed = 0;
                    dryTime = 0;
                    drySpeed = 0;
                    break;
            }
        }
    }
}
