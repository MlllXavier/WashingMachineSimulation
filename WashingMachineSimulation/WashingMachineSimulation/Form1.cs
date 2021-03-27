using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WashingMachineSimulation
{
    public partial class Form1 : Form
    {
        int ifStartUp = 0;//判断是否启动的标识
        int ifWashing = 0;//判断是否正在洗的标识
        int SuperCleanWash = 0;//超净洗
        int SuperRinse = 0;//超漂洗
        WashClothes washClothes;
        WashRattler washRattler;
        ClothesType clothesType = new ClothesType(0);//洗衣类型
        OrderTimer orderTime;//预约时间
        ControlTemperature temperature;//温度
        ControlSpeed speed;//脱水速度
        System.Timers.Timer orderTimer = new System.Timers.Timer(10);//预约定时器
        int orderComplete = 0;
        int washComplete = 0;
        int orderHour = 0;
        int orderMin = 0;
        int orderSecond = 0;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            lblTime.Font = new System.Drawing.Font("DigiNumlED", 36);
            washRattler = new WashRattler(ref rattler1);
        }

        private delegate void MyDelegate();

        private void Modify() 
        {
            if (lblTime.InvokeRequired)
            {
                lblTime.Invoke(new MyDelegate(Modify));
            }
            else
            {
                string hour,min,second;
                if (orderHour < 10) hour = "0" + orderHour.ToString();
                else hour = orderHour.ToString();
                if (orderMin < 10) min = "0" + orderMin.ToString();
                else min = orderMin.ToString();
                if (orderSecond < 10) second = "0" + orderSecond.ToString();
                else second = orderSecond.ToString();
                lblTime.Text = hour + ":" + min + ":" + second;
            }
        }
        private void Order_Elapsed(object sender, EventArgs e)
        {
            //秒数减一
            if(orderSecond > 0) orderSecond--;
            else
            {
                orderSecond = 59;
                if(orderMin > 0) orderMin--;
                else
                {
                    orderMin = 59;
                    if(orderHour > 0) orderHour--;
                    else
                    {
                        orderHour = 0;
                        orderMin = 0;
                        orderSecond = 0;
                        orderComplete = 1;//////////////////////////////////////////////
                        if(washComplete == 0)
                        {
                            washComplete = 1;
                            washClothes.clothesType = clothesType;
                            if (SuperCleanWash == 1)
                            {
                                clothesType.cleanWashTime += 10;//净洗时间加长
                            }
                            if (SuperRinse == 1)
                            {
                                clothesType.rinseTimes++;//漂洗次数加一
                            }
                            int tempTime = clothesType.TotleTime()+clothesType.rinseTime;
                            //设置洗涤倒数时间
                            if (tempTime > 60)
                            {
                                orderHour = tempTime / 60;
                                orderMin = tempTime % 60;
                            }
                            else
                            {
                                orderMin = tempTime;
                            }
                            orderTimer.Start();//洗涤倒计时
                            washClothes.StartWash(ref washRattler);
                        }
                        else
                        {
                            //全部停止-----------------------------
                            orderTimer.Stop();
                            ifWashing = 0;
                            lblStartPause.Visible = false; 
                        }
                    }
                }
            }
            Modify();
        }

        int ifPause = 0;//用来标识是暂停还是新的开始
        private void btnStartPause_Click(object sender, EventArgs e)//启动/暂停按钮
        {
            if(ifStartUp == 1)
            {
                if(ifWashing == 0)//开始
                {
                    clothesType = new ClothesType(userControl11.Flag);
                    if(speedChanged == 1)
                        clothesType.cleanWashSpeed = speed.Speed;
                    ifWashing = 1;
                    lblStartPause.Visible = true;
                    orderHour = orderTime.OrderTime;
                    orderTime = new OrderTimer();
                    orderTimer.Start();//开始预约倒计时
                }
                else
                {
                    if (ifPause == 0)//暂停
                    {
                        ifPause = 1;
                        lblStartPause.Visible = false;
                        washClothes.pause();
                        washRattler.Pause();
                        orderTimer.Stop();
                    }
                    else//继续
                    {
                        ifPause = 0;
                        lblStartPause.Visible = true;
                        washClothes.start();
                        washRattler.Start();
                        orderTimer.Start();
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)//选择预约时间
        {
            if(ifStartUp == 1 && ifWashing == 0)
            {
                orderTime.ChangeTimer();
                if(orderTime.OrderTime < 10)
                {
                    lblTime.Text = "0" + orderTime.OrderTime + ":00:00";
                }
                else
                {
                    lblTime.Text = orderTime.OrderTime + ":00:00";
                }
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)//选择温度
        {
            if(ifStartUp == 1 && ifWashing == 0)
            {
                temperature.ChangeTemperature();
                lblTemperature.Location = new Point(30, 16 + (temperature.iTemperature - 1) * 28);
            }
        }

        private void btnCleanWash_Click(object sender, EventArgs e)//是否超净洗
        {
            if(ifStartUp == 1 && ifWashing == 0)
            {
                if (SuperCleanWash == 0)
                {
                    SuperCleanWash = 1;
                    lblSuperClean.Visible = true;
                }
                else
                {
                    SuperCleanWash = 0;
                    lblSuperClean.Visible = false;
                }
            }
        }

        private void btnRinse_Click(object sender, EventArgs e)//是否超漂洗
        {
            if(ifStartUp == 1 && ifWashing == 0)
            {
                if (SuperRinse == 0)
                {
                    SuperRinse = 1;
                    lblSuperRinse.Visible = true;
                }
                else
                {
                    SuperRinse = 0;
                    lblSuperRinse.Visible = false;
                }
            }
        }

        int speedChanged = 0;
        private void btnSpeed_Click(object sender, EventArgs e)//选择脱水速度
        {
            if(ifStartUp == 1 && ifWashing == 0)
            {
                speedChanged = 1;
                speed.ChangeSpeed();
                lblSpeed.Location = new Point(113, 16 + (speed.iSpeed - 1) * 28);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ifStartUp == 0)
            {
                //初始化
                lblTime.Visible = true;
                lblTemperature.Visible = true;
                lblSpeed.Visible = true;
                washClothes = new WashClothes();
                orderTime = new OrderTimer();
                temperature = new ControlTemperature();
                speed = new ControlSpeed();
                clothesType = new ClothesType(0);
                orderTimer = new System.Timers.Timer(10);
                orderTimer.Elapsed += new System.Timers.ElapsedEventHandler(Order_Elapsed);
                ifStartUp = 1;
            }
            else
            {
                //关闭系统，将参数重置为初始参数
                ifPause = 0;
                ifWashing = 0;
                orderHour = 0;
                orderMin = 0;
                orderSecond = 0;
                orderComplete = 0;
                washComplete = 0;
                SuperCleanWash = 0;
                SuperRinse = 0;
                lblTime.Visible = false;
                lblTemperature.Visible = false;
                lblSpeed.Visible = false;
                lblSuperClean.Visible = false;
                lblSuperRinse.Visible = false;
                lblStartPause.Visible = false;
                orderTimer.Stop();
                washRattler.Stop();
                orderTimer.Stop();
                lblTime.Text = "00:00:00";
                ifStartUp = 0;
            }
        }
    }
}
