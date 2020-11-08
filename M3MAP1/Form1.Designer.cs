namespace M3MAP1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bn_Start = new System.Windows.Forms.Button();
            this.tb_ResultGen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LowBound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_UpperBound = new System.Windows.Forms.TextBox();
            this.bn_StartFib = new System.Windows.Forms.Button();
            this.tb_FibMonitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FibNum = new System.Windows.Forms.TextBox();
            this.bn_StopGenNum = new System.Windows.Forms.Button();
            this.bt_StopCalc = new System.Windows.Forms.Button();
            this.bn_Suspend = new System.Windows.Forms.Button();
            this.bn_Proceed = new System.Windows.Forms.Button();
            this.bt_Restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(13, 13);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(173, 23);
            this.bn_Start.TabIndex = 0;
            this.bn_Start.Text = "Start";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // tb_ResultGen
            // 
            this.tb_ResultGen.Location = new System.Drawing.Point(13, 95);
            this.tb_ResultGen.Multiline = true;
            this.tb_ResultGen.Name = "tb_ResultGen";
            this.tb_ResultGen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_ResultGen.Size = new System.Drawing.Size(172, 262);
            this.tb_ResultGen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LowBound";
            // 
            // tb_LowBound
            // 
            this.tb_LowBound.Location = new System.Drawing.Point(85, 43);
            this.tb_LowBound.Name = "tb_LowBound";
            this.tb_LowBound.Size = new System.Drawing.Size(100, 20);
            this.tb_LowBound.TabIndex = 3;
            this.tb_LowBound.TextChanged += new System.EventHandler(this.tb_LowBound_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UpperBound";
            // 
            // tb_UpperBound
            // 
            this.tb_UpperBound.Location = new System.Drawing.Point(85, 69);
            this.tb_UpperBound.Name = "tb_UpperBound";
            this.tb_UpperBound.Size = new System.Drawing.Size(100, 20);
            this.tb_UpperBound.TabIndex = 3;
            this.tb_UpperBound.TextChanged += new System.EventHandler(this.tb_UpperBound_TextChanged);
            // 
            // bn_StartFib
            // 
            this.bn_StartFib.Location = new System.Drawing.Point(379, 12);
            this.bn_StartFib.Name = "bn_StartFib";
            this.bn_StartFib.Size = new System.Drawing.Size(173, 23);
            this.bn_StartFib.TabIndex = 0;
            this.bn_StartFib.Text = "Start";
            this.bn_StartFib.UseVisualStyleBackColor = true;
            this.bn_StartFib.Click += new System.EventHandler(this.bn_StartFib_Click);
            // 
            // tb_FibMonitor
            // 
            this.tb_FibMonitor.Location = new System.Drawing.Point(379, 94);
            this.tb_FibMonitor.Multiline = true;
            this.tb_FibMonitor.Name = "tb_FibMonitor";
            this.tb_FibMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_FibMonitor.Size = new System.Drawing.Size(172, 262);
            this.tb_FibMonitor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fib num->";
            // 
            // tb_FibNum
            // 
            this.tb_FibNum.Location = new System.Drawing.Point(451, 42);
            this.tb_FibNum.Name = "tb_FibNum";
            this.tb_FibNum.Size = new System.Drawing.Size(100, 20);
            this.tb_FibNum.TabIndex = 3;
            this.tb_FibNum.TextChanged += new System.EventHandler(this.tb_FibNum_TextChanged);
            // 
            // bn_StopGenNum
            // 
            this.bn_StopGenNum.Location = new System.Drawing.Point(192, 94);
            this.bn_StopGenNum.Name = "bn_StopGenNum";
            this.bn_StopGenNum.Size = new System.Drawing.Size(75, 23);
            this.bn_StopGenNum.TabIndex = 4;
            this.bn_StopGenNum.Text = "<- Stop";
            this.bn_StopGenNum.UseVisualStyleBackColor = true;
            this.bn_StopGenNum.Click += new System.EventHandler(this.bn_StopGenNum_Click);
            // 
            // bt_StopCalc
            // 
            this.bt_StopCalc.Location = new System.Drawing.Point(298, 95);
            this.bt_StopCalc.Name = "bt_StopCalc";
            this.bt_StopCalc.Size = new System.Drawing.Size(75, 23);
            this.bt_StopCalc.TabIndex = 4;
            this.bt_StopCalc.Text = "Stop ->";
            this.bt_StopCalc.UseVisualStyleBackColor = true;
            this.bt_StopCalc.Click += new System.EventHandler(this.bt_StopCalc_Click);
            // 
            // bn_Suspend
            // 
            this.bn_Suspend.Location = new System.Drawing.Point(298, 125);
            this.bn_Suspend.Name = "bn_Suspend";
            this.bn_Suspend.Size = new System.Drawing.Size(75, 23);
            this.bn_Suspend.TabIndex = 5;
            this.bn_Suspend.Text = "Suspend ->";
            this.bn_Suspend.UseVisualStyleBackColor = true;
            this.bn_Suspend.Click += new System.EventHandler(this.bn_Suspend_Click);
            // 
            // bn_Proceed
            // 
            this.bn_Proceed.Location = new System.Drawing.Point(298, 154);
            this.bn_Proceed.Name = "bn_Proceed";
            this.bn_Proceed.Size = new System.Drawing.Size(75, 23);
            this.bn_Proceed.TabIndex = 5;
            this.bn_Proceed.Text = "Resume ->";
            this.bn_Proceed.UseVisualStyleBackColor = true;
            this.bn_Proceed.Click += new System.EventHandler(this.bn_Proceed_Click);
            // 
            // bt_Restart
            // 
            this.bt_Restart.Location = new System.Drawing.Point(298, 183);
            this.bt_Restart.Name = "bt_Restart";
            this.bt_Restart.Size = new System.Drawing.Size(75, 23);
            this.bt_Restart.TabIndex = 5;
            this.bt_Restart.Text = "Restart ->";
            this.bt_Restart.UseVisualStyleBackColor = true;
            this.bt_Restart.Click += new System.EventHandler(this.bt_Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 399);
            this.Controls.Add(this.bt_Restart);
            this.Controls.Add(this.bn_Proceed);
            this.Controls.Add(this.bn_Suspend);
            this.Controls.Add(this.bt_StopCalc);
            this.Controls.Add(this.bn_StopGenNum);
            this.Controls.Add(this.tb_UpperBound);
            this.Controls.Add(this.tb_FibNum);
            this.Controls.Add(this.tb_LowBound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_FibMonitor);
            this.Controls.Add(this.tb_ResultGen);
            this.Controls.Add(this.bn_StartFib);
            this.Controls.Add(this.bn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.TextBox tb_ResultGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_LowBound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_UpperBound;
        private System.Windows.Forms.Button bn_StartFib;
        private System.Windows.Forms.TextBox tb_FibMonitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FibNum;
        private System.Windows.Forms.Button bn_StopGenNum;
        private System.Windows.Forms.Button bt_StopCalc;
        private System.Windows.Forms.Button bn_Suspend;
        private System.Windows.Forms.Button bn_Proceed;
        private System.Windows.Forms.Button bt_Restart;
    }
}

