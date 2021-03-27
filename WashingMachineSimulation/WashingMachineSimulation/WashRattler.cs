using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineSimulation
{
    class WashRattler
    {
        RattlerControl1.Rattler rattler;

        public WashRattler(ref RattlerControl1.Rattler r)
        {
            rattler = r;
        }

        static int itemp = 0;
        System.Timers.Timer tempTimer = new System.Timers.Timer(1000);
        System.Timers.Timer totalWashTimer = new System.Timers.Timer(); //洗衣监听
        System.Timers.Timer putWaterTimer = new System.Timers.Timer(); //放水到指定水位监听
        System.Timers.Timer singleWashTimer = new System.Timers.Timer(); //正转反转监听

        private int WashTime = 0, WashSpd = 0, isRinse = 0;

        //putWaterTimer监听是否放够80水位，放够后转动涡轮
        private void PutWater()//进水
        {
            putWaterTimer = new System.Timers.Timer(100);
            putWaterTimer.Elapsed += PutWaterTimer_Elapsed;
            if(isRinse == 0)
            {
                putWaterTimer.AutoReset = true;
                rattler.WaterState = RattlerControl1.WATER_STATE.In;
                rattler.HeatState = RattlerControl1.HEAT_STATE.ING;//加热
            }
            else
            {
                putWaterTimer.AutoReset = false;
            }
            putWaterTimer.Start();
        }

        int waterState = 0;
        int rotateState = 0;
        public void Pause()
        {
            if (rattler.WaterState == RattlerControl1.WATER_STATE.In)
                waterState = 1;
            else if (rattler.WaterState == RattlerControl1.WATER_STATE.Out)
                waterState = 2;
            else
                waterState = 0;
            if (rattler.RotateState == RattlerControl1.ROTATE_STATE.ForwardRotating)
                rotateState = 1;
            else if (rattler.RotateState == RattlerControl1.ROTATE_STATE.ReversaRotating)
                rotateState = 2;
            else
                rotateState = 0;
            rattler.WaterState = RattlerControl1.WATER_STATE.Stop;
            rattler.RotateState = RattlerControl1.ROTATE_STATE.Stop;
            rattler.HeatState = RattlerControl1.HEAT_STATE.END;
            tempTimer.Stop();
            totalWashTimer.Stop();
            singleWashTimer.Stop();
        }
        public void Start()
        {
            if(waterState == 1)
                rattler.WaterState = RattlerControl1.WATER_STATE.In;
            else if(waterState == 2)
                rattler.WaterState = RattlerControl1.WATER_STATE.Out;
            else
                rattler.WaterState = RattlerControl1.WATER_STATE.Stop;
            if(rotateState == 1)
                rattler.RotateState = RattlerControl1.ROTATE_STATE.ForwardRotating;
            else if(rotateState == 2)
                rattler.RotateState = RattlerControl1.ROTATE_STATE.ReversaRotating;
            else
                rattler.RotateState = RattlerControl1.ROTATE_STATE.Stop;
            rattler.HeatState = RattlerControl1.HEAT_STATE.ING;
            tempTimer.Start();
            totalWashTimer = new System.Timers.Timer((WashTime - itemp) * 1000 + 1);
            totalWashTimer.AutoReset = false;
            totalWashTimer.Elapsed += TotalWashTimer_Elapsed;
            totalWashTimer.Start();
            singleWashTimer.Start();
        }

        public void Stop()
        {
            rattler.WaterState = RattlerControl1.WATER_STATE.Stop;
            rattler.WaterLevel = 0;
            rattler.HeatState = RattlerControl1.HEAT_STATE.END;
            rattler.RotateState = RattlerControl1.ROTATE_STATE.Stop;
        }

        private void PutWaterTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(isRinse == 0)
            {
                if (rattler.WaterLevel >= 70.0f)
                {
                    rattler.WaterState = RattlerControl1.WATER_STATE.Stop;

                    putWaterTimer.Stop();

                    rattler.HeatState = RattlerControl1.HEAT_STATE.END;

                    //正转反转间隔
                    singleWashTimer = new System.Timers.Timer(4000);
                    singleWashTimer.AutoReset = true;
                    singleWashTimer.Elapsed += SingleWashTimer_Elapsed;
                    singleWashTimer.Start();

                    //涡轮参数
                    rattler.RotateSpd = WashSpd;
                    rattler.RotateState = RattlerControl1.ROTATE_STATE.ForwardRotating;

                    //洗衣定时
                    totalWashTimer = new System.Timers.Timer(WashTime * 1000 + 1);
                    totalWashTimer.AutoReset = false;
                    totalWashTimer.Elapsed += TotalWashTimer_Elapsed;
                    totalWashTimer.Start();
                    //计算时间
                    tempTimer.Elapsed += new System.Timers.ElapsedEventHandler(tempTimer_Tick);
                    tempTimer.Start();
                }
            }
            else
            {
                putWaterTimer.Stop();
                rattler.HeatState = RattlerControl1.HEAT_STATE.END;
                rattler.RotateSpd = WashSpd;
                rattler.RotateState = RattlerControl1.ROTATE_STATE.ForwardRotating;
                totalWashTimer = new System.Timers.Timer(WashTime * 1000 + 1);
                totalWashTimer.AutoReset = false;
                totalWashTimer.Elapsed += TotalWashTimer_Elapsed;
                totalWashTimer.Start();
                tempTimer.Elapsed += new System.Timers.ElapsedEventHandler(tempTimer_Tick);
                tempTimer.Start();
            }
        }

        private void tempTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            itemp++;
        }

        //此处time单位为秒
        public void Wash(int time, int spd, int isr)
        {
            isRinse = isr;
            WashTime = time;
            WashSpd = spd;
            isRinse = isr;
            itemp = 0;
            PutWater();
        }

        //洗衣结束，关闭转动，排水
        private void TotalWashTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            rattler.RotateState = RattlerControl1.ROTATE_STATE.Stop;
            rattler.WaterState = RattlerControl1.WATER_STATE.Out;
        }

        private void SingleWashTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (rattler.RotateState == RattlerControl1.ROTATE_STATE.ForwardRotating)
                rattler.RotateState = RattlerControl1.ROTATE_STATE.ReversaRotating;
            else if (rattler.RotateState == RattlerControl1.ROTATE_STATE.ReversaRotating)
                rattler.RotateState = RattlerControl1.ROTATE_STATE.ForwardRotating;
            else singleWashTimer.Stop();
        }
    }
}
