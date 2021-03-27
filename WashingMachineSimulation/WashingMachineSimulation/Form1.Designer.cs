namespace WashingMachineSimulation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnCleanWash = new System.Windows.Forms.Button();
            this.btnRinse = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartPause = new System.Windows.Forms.Label();
            this.lblSuperRinse = new System.Windows.Forms.Label();
            this.lblSuperClean = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.userControl11 = new KnobControl.UserControl1();
            this.rattler1 = new RattlerControl1.Rattler();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemperature
            // 
            this.btnTemperature.BackColor = System.Drawing.Color.Black;
            this.btnTemperature.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTemperature.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemperature.Location = new System.Drawing.Point(3, 149);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(81, 40);
            this.btnTemperature.TabIndex = 1;
            this.btnTemperature.Text = "温度";
            this.btnTemperature.UseVisualStyleBackColor = false;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackColor = System.Drawing.Color.Black;
            this.btnSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSpeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpeed.Location = new System.Drawing.Point(84, 149);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(81, 40);
            this.btnSpeed.TabIndex = 2;
            this.btnSpeed.Text = "速度";
            this.btnSpeed.UseVisualStyleBackColor = false;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnCleanWash
            // 
            this.btnCleanWash.BackColor = System.Drawing.Color.Black;
            this.btnCleanWash.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCleanWash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCleanWash.Location = new System.Drawing.Point(165, 149);
            this.btnCleanWash.Name = "btnCleanWash";
            this.btnCleanWash.Size = new System.Drawing.Size(81, 40);
            this.btnCleanWash.TabIndex = 3;
            this.btnCleanWash.Text = "超净洗";
            this.btnCleanWash.UseVisualStyleBackColor = false;
            this.btnCleanWash.Click += new System.EventHandler(this.btnCleanWash_Click);
            // 
            // btnRinse
            // 
            this.btnRinse.BackColor = System.Drawing.Color.Black;
            this.btnRinse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRinse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRinse.Location = new System.Drawing.Point(246, 149);
            this.btnRinse.Name = "btnRinse";
            this.btnRinse.Size = new System.Drawing.Size(81, 40);
            this.btnRinse.TabIndex = 4;
            this.btnRinse.Text = "超漂洗";
            this.btnRinse.UseVisualStyleBackColor = false;
            this.btnRinse.Click += new System.EventHandler(this.btnRinse_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(402, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(45, 80);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "预约";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblStartPause);
            this.panel1.Controls.Add(this.lblSuperRinse);
            this.panel1.Controls.Add(this.lblSuperClean);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.lblTemperature);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTemperature);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnSpeed);
            this.panel1.Controls.Add(this.btnStartPause);
            this.panel1.Controls.Add(this.btnCleanWash);
            this.panel1.Controls.Add(this.btnRinse);
            this.panel1.Location = new System.Drawing.Point(867, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 192);
            this.panel1.TabIndex = 7;
            // 
            // lblStartPause
            // 
            this.lblStartPause.BackColor = System.Drawing.Color.Red;
            this.lblStartPause.Location = new System.Drawing.Point(400, 99);
            this.lblStartPause.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartPause.Name = "lblStartPause";
            this.lblStartPause.Size = new System.Drawing.Size(14, 8);
            this.lblStartPause.TabIndex = 18;
            this.lblStartPause.Visible = false;
            // 
            // lblSuperRinse
            // 
            this.lblSuperRinse.BackColor = System.Drawing.Color.Red;
            this.lblSuperRinse.Location = new System.Drawing.Point(278, 100);
            this.lblSuperRinse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuperRinse.Name = "lblSuperRinse";
            this.lblSuperRinse.Size = new System.Drawing.Size(14, 8);
            this.lblSuperRinse.TabIndex = 19;
            this.lblSuperRinse.Visible = false;
            // 
            // lblSuperClean
            // 
            this.lblSuperClean.BackColor = System.Drawing.Color.Red;
            this.lblSuperClean.Location = new System.Drawing.Point(199, 100);
            this.lblSuperClean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuperClean.Name = "lblSuperClean";
            this.lblSuperClean.Size = new System.Drawing.Size(14, 8);
            this.lblSuperClean.TabIndex = 18;
            this.lblSuperClean.Visible = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BackColor = System.Drawing.Color.Red;
            this.lblSpeed.Location = new System.Drawing.Point(113, 16);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(14, 8);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Visible = false;
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.Red;
            this.lblTemperature.Location = new System.Drawing.Point(30, 16);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(14, 8);
            this.lblTemperature.TabIndex = 8;
            this.lblTemperature.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(176, 3);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(220, 80);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(135, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "1200";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(135, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(135, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "800";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(135, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "400";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 8);
            this.label6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(52, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(52, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(52, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(52, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正等线", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(357, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "启动/暂停";
            // 
            // btnStartPause
            // 
            this.btnStartPause.BackColor = System.Drawing.Color.Black;
            this.btnStartPause.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartPause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartPause.Image = global::WashingMachineSimulation.Properties.Resources.播放暂停__1_;
            this.btnStartPause.Location = new System.Drawing.Point(358, 148);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(89, 40);
            this.btnStartPause.TabIndex = 5;
            this.btnStartPause.UseVisualStyleBackColor = false;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // userControl11
            // 
            this.userControl11.Flag = 6;
            this.userControl11.Location = new System.Drawing.Point(494, 11);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(368, 205);
            this.userControl11.TabIndex = 9;
            // 
            // rattler1
            // 
            this.rattler1.Angle = 0F;
            this.rattler1.BackColor = System.Drawing.Color.White;
            this.rattler1.HeatState = RattlerControl1.HEAT_STATE.END;
            this.rattler1.Location = new System.Drawing.Point(41, 172);
            this.rattler1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rattler1.Name = "rattler1";
            this.rattler1.RotateSpd = 3F;
            this.rattler1.RotateState = RattlerControl1.ROTATE_STATE.Stop;
            this.rattler1.Size = new System.Drawing.Size(421, 393);
            this.rattler1.TabIndex = 11;
            this.rattler1.WaterLevel = 0D;
            this.rattler1.WaterState = RattlerControl1.WATER_STATE.Stop;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WashingMachineSimulation.Properties.Resources.洗衣机;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 607);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WashingMachineSimulation.Properties.Resources.电源;
            this.pictureBox2.Location = new System.Drawing.Point(1266, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(1265, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "电源";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 635);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rattler1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnCleanWash;
        private System.Windows.Forms.Button btnRinse;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblStartPause;
        private System.Windows.Forms.Label lblSuperRinse;
        private System.Windows.Forms.Label lblSuperClean;
        private KnobControl.UserControl1 userControl11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RattlerControl1.Rattler rattler1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
    }
}

