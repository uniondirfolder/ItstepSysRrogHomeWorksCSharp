namespace Task_1_2_3
{
    partial class MainForm
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
            this.groupBox_Processes = new System.Windows.Forms.GroupBox();
            this.listView_Processes = new System.Windows.Forms.ListView();
            this.NameProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_StopProcListMonitoring = new System.Windows.Forms.Button();
            this.button_StartMonitorProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_UpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.PidProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStartProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeJobeProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThreadsCountProc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcCopy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_RunManual = new System.Windows.Forms.ComboBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.groupBox_Processes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Processes
            // 
            this.groupBox_Processes.Controls.Add(this.textBox_Path);
            this.groupBox_Processes.Controls.Add(this.comboBox_RunManual);
            this.groupBox_Processes.Controls.Add(this.listView_Processes);
            this.groupBox_Processes.Controls.Add(this.button_StopProcListMonitoring);
            this.groupBox_Processes.Controls.Add(this.button_StartMonitorProc);
            this.groupBox_Processes.Controls.Add(this.label1);
            this.groupBox_Processes.Controls.Add(this.numericUpDown_UpdateInterval);
            this.groupBox_Processes.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Processes.Name = "groupBox_Processes";
            this.groupBox_Processes.Size = new System.Drawing.Size(775, 462);
            this.groupBox_Processes.TabIndex = 0;
            this.groupBox_Processes.TabStop = false;
            this.groupBox_Processes.Text = "Processes list monitor";
            // 
            // listView_Processes
            // 
            this.listView_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProc,
            this.PidProc,
            this.TimeStartProc,
            this.TimeJobeProc,
            this.ThreadsCountProc,
            this.ProcCopy});
            this.listView_Processes.HideSelection = false;
            this.listView_Processes.Location = new System.Drawing.Point(7, 90);
            this.listView_Processes.Name = "listView_Processes";
            this.listView_Processes.Size = new System.Drawing.Size(762, 366);
            this.listView_Processes.TabIndex = 4;
            this.listView_Processes.UseCompatibleStateImageBehavior = false;
            this.listView_Processes.View = System.Windows.Forms.View.Details;
            // 
            // NameProc
            // 
            this.NameProc.Text = "Name";
            this.NameProc.Width = 360;
            // 
            // button_StopProcListMonitoring
            // 
            this.button_StopProcListMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_StopProcListMonitoring.Location = new System.Drawing.Point(7, 59);
            this.button_StopProcListMonitoring.Name = "button_StopProcListMonitoring";
            this.button_StopProcListMonitoring.Size = new System.Drawing.Size(75, 23);
            this.button_StopProcListMonitoring.TabIndex = 3;
            this.button_StopProcListMonitoring.Text = "Stop";
            this.button_StopProcListMonitoring.UseVisualStyleBackColor = true;
            this.button_StopProcListMonitoring.Click += new System.EventHandler(this.button_StopProcListMonitoring_Click);
            // 
            // button_StartMonitorProc
            // 
            this.button_StartMonitorProc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_StartMonitorProc.Location = new System.Drawing.Point(7, 20);
            this.button_StartMonitorProc.Name = "button_StartMonitorProc";
            this.button_StartMonitorProc.Size = new System.Drawing.Size(75, 23);
            this.button_StartMonitorProc.TabIndex = 3;
            this.button_StartMonitorProc.Text = "Start";
            this.button_StartMonitorProc.UseVisualStyleBackColor = true;
            this.button_StartMonitorProc.Click += new System.EventHandler(this.button_StartMonitorProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update interval in sec.";
            // 
            // numericUpDown_UpdateInterval
            // 
            this.numericUpDown_UpdateInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_UpdateInterval.Location = new System.Drawing.Point(694, 59);
            this.numericUpDown_UpdateInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_UpdateInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_UpdateInterval.Name = "numericUpDown_UpdateInterval";
            this.numericUpDown_UpdateInterval.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_UpdateInterval.TabIndex = 1;
            this.numericUpDown_UpdateInterval.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // PidProc
            // 
            this.PidProc.Text = "PID";
            // 
            // TimeStartProc
            // 
            this.TimeStartProc.Text = "Time Start";
            // 
            // TimeJobeProc
            // 
            this.TimeJobeProc.Text = "Proc Time Job";
            this.TimeJobeProc.Width = 81;
            // 
            // ThreadsCountProc
            // 
            this.ThreadsCountProc.Text = "Threads count";
            this.ThreadsCountProc.Width = 100;
            // 
            // ProcCopy
            // 
            this.ProcCopy.Text = "Process Copy";
            this.ProcCopy.Width = 88;
            // 
            // comboBox_RunManual
            // 
            this.comboBox_RunManual.FormattingEnabled = true;
            this.comboBox_RunManual.Location = new System.Drawing.Point(89, 21);
            this.comboBox_RunManual.Name = "comboBox_RunManual";
            this.comboBox_RunManual.Size = new System.Drawing.Size(90, 21);
            this.comboBox_RunManual.TabIndex = 5;
            this.comboBox_RunManual.SelectedIndexChanged += new System.EventHandler(this.comboBox_RunManual_SelectedIndexChanged);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(185, 21);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(584, 20);
            this.textBox_Path.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.groupBox_Processes);
            this.Name = "MainForm";
            this.Text = "Task: 1,2,3,4";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_Processes.ResumeLayout(false);
            this.groupBox_Processes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdateInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Processes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_UpdateInterval;
        private System.Windows.Forms.Button button_StopProcListMonitoring;
        private System.Windows.Forms.Button button_StartMonitorProc;
        private System.Windows.Forms.ListView listView_Processes;
        private System.Windows.Forms.ColumnHeader NameProc;
        private System.Windows.Forms.ColumnHeader PidProc;
        private System.Windows.Forms.ColumnHeader TimeStartProc;
        private System.Windows.Forms.ColumnHeader TimeJobeProc;
        private System.Windows.Forms.ColumnHeader ThreadsCountProc;
        private System.Windows.Forms.ColumnHeader ProcCopy;
        private System.Windows.Forms.ComboBox comboBox_RunManual;
        private System.Windows.Forms.TextBox textBox_Path;
    }
}

