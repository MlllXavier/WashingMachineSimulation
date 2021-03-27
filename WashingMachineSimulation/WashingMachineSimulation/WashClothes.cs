using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class WashClothes
    {
        public ClothesType clothesType;//衣物类型
        public WashRattler washRattler;//洗衣滚筒
        static int itemp = 0, isClean = 0, isRinse = 0;
        System.Timers.Timer tempTimer = new System.Timers.Timer(1000);
        System.Timers.Timer cleanWashTimer = new System.Timers.Timer();//判断净洗是否完成
        System.Timers.Timer rinseTimer = new System.Timers.Timer();//判断漂洗是否完成

        public void StartWash(ref WashRattler washR)
        {
            washRattler = washR;
            tempTimer.Elapsed += new System.Timers.ElapsedEventHandler(tempTimer_Tick);

            cleanWashTimer.Interval = (clothesType.cleanWashTime + 16) * 1000 + 1;
            cleanWashTimer.AutoReset = false;
            cleanWashTimer.Elapsed += new System.Timers.ElapsedEventHandler(CleanWashTimer_Elapsed);
            rinseTimer.Interval = ((clothesType.rinseTime + 16) * clothesType.rinseTimes) * 1000 + 1;
            rinseTimer.AutoReset = false;
            rinseTimer.Elapsed += new System.Timers.ElapsedEventHandler(RinseTimer_Elapsed);
            CleanWash();//开始净洗
        }

        private void tempTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            itemp++;
        }

        public void pause()
        {
            if(isClean == 0)//正在净洗
            {
                cleanWashTimer.Stop();
            }
            else if(isRinse == 0)//正在漂洗
            {
                rinseTimer.Stop();
            }
            else//正在脱水
            {
                
            }
            tempTimer.Stop();
        }
        public void start()
        {
            if (isClean == 0)//正在净洗
            {
                if (clothesType.cleanWashTime + 16 - itemp > 0)
                    cleanWashTimer = new System.Timers.Timer((clothesType.cleanWashTime + 16 - itemp) * 1000 + 1);
                else
                    cleanWashTimer = new System.Timers.Timer(1);
                cleanWashTimer.AutoReset = false;
                cleanWashTimer.Elapsed += new System.Timers.ElapsedEventHandler(CleanWashTimer_Elapsed);
                cleanWashTimer.Start();
            }
            else if (isRinse == 0)//正在漂洗
            {
                if (clothesType.rinseTime + 16 * clothesType.rinseTimes - itemp > 0)
                    rinseTimer = new System.Timers.Timer((clothesType.rinseTime + 16 * clothesType.rinseTimes - itemp) * 1000 + 1);
                else
                    rinseTimer = new System.Timers.Timer(1);
                rinseTimer.AutoReset = false;
                rinseTimer.Elapsed += new System.Timers.ElapsedEventHandler(RinseTimer_Elapsed);
                rinseTimer.Start();
            }
            else//正在脱水
            {

            }
        }

        private void CleanWashTimer_Elapsed(object sender, EventArgs e)
        {
            isClean = 1;
            cleanWashTimer.Stop();
            Rinse();
        }

        private void RinseTimer_Elapsed(object sender, EventArgs e)
        {
            isRinse = 1;
            rinseTimer.Stop();
            Dry();
        }

        void CleanWash()//净洗
        {
            tempTimer.Start();
            cleanWashTimer.Start();
            washRattler.Wash(clothesType.cleanWashTime, clothesType.cleanWashSpeed/20, 0);
        }

        void Rinse()//漂洗
        {
            
            rinseTimer.Start();
            for (int i = 0; i < clothesType.rinseTimes; i++)
            {
                washRattler.Wash(clothesType.rinseTime, clothesType.rinseSpeed/20, 0);
            }
        }

        void Dry()//甩干
        {
            washRattler.Wash(clothesType.dryTime, clothesType.drySpeed/20, 1);
        }
    }
}
