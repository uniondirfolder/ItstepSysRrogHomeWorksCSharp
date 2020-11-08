namespace M2PHW
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Kill_Task_2 = new System.Windows.Forms.Button();
            this.label_Codend_Task_2 = new System.Windows.Forms.Label();
            this.textBox_Path_Task_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Task_2_Start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Task_4_Go = new System.Windows.Forms.Button();
            this.label_Task_4_Find = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Task_4_Word = new System.Windows.Forms.TextBox();
            this.label_Ttask_4_Proga = new System.Windows.Forms.Label();
            this.textBox_Task_4_FilePath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_Res_Task_3 = new System.Windows.Forms.Label();
            this.button_Calc_Task_3 = new System.Windows.Forms.Button();
            this.nud_Left = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.nud_Right = new System.Windows.Forms.NumericUpDown();
            this.cb_OPeration = new System.Windows.Forms.ComboBox();
            this.label_Path_file = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Task_1_Start = new System.Windows.Forms.Button();
            this.label_Task_1_End = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Right)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Task_1_End);
            this.groupBox1.Controls.Add(this.button_Task_1_Start);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Kill_Task_2);
            this.groupBox2.Controls.Add(this.label_Codend_Task_2);
            this.groupBox2.Controls.Add(this.textBox_Path_Task_2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_Task_2_Start);
            this.groupBox2.Location = new System.Drawing.Point(13, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task 2";
            // 
            // button_Kill_Task_2
            // 
            this.button_Kill_Task_2.Location = new System.Drawing.Point(8, 47);
            this.button_Kill_Task_2.Name = "button_Kill_Task_2";
            this.button_Kill_Task_2.Size = new System.Drawing.Size(75, 23);
            this.button_Kill_Task_2.TabIndex = 3;
            this.button_Kill_Task_2.Text = "Kill proc";
            this.button_Kill_Task_2.UseVisualStyleBackColor = true;
            this.button_Kill_Task_2.Click += new System.EventHandler(this.button_Kill_Task_2_Click);
            // 
            // label_Codend_Task_2
            // 
            this.label_Codend_Task_2.AutoSize = true;
            this.label_Codend_Task_2.Location = new System.Drawing.Point(692, 22);
            this.label_Codend_Task_2.Name = "label_Codend_Task_2";
            this.label_Codend_Task_2.Size = new System.Drawing.Size(51, 13);
            this.label_Codend_Task_2.TabIndex = 2;
            this.label_Codend_Task_2.Text = "CodeEnd";
            // 
            // textBox_Path_Task_2
            // 
            this.textBox_Path_Task_2.Location = new System.Drawing.Point(158, 19);
            this.textBox_Path_Task_2.Name = "textBox_Path_Task_2";
            this.textBox_Path_Task_2.Size = new System.Drawing.Size(528, 20);
            this.textBox_Path_Task_2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File full path";
            // 
            // button_Task_2_Start
            // 
            this.button_Task_2_Start.Location = new System.Drawing.Point(8, 17);
            this.button_Task_2_Start.Name = "button_Task_2_Start";
            this.button_Task_2_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Task_2_Start.TabIndex = 0;
            this.button_Task_2_Start.Text = "Start";
            this.button_Task_2_Start.UseVisualStyleBackColor = true;
            this.button_Task_2_Start.Click += new System.EventHandler(this.button_Task_2_Start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Task_4_Go);
            this.groupBox3.Controls.Add(this.label_Task_4_Find);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox_Task_4_Word);
            this.groupBox3.Controls.Add(this.label_Ttask_4_Proga);
            this.groupBox3.Controls.Add(this.textBox_Task_4_FilePath);
            this.groupBox3.Location = new System.Drawing.Point(13, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task 4";
            // 
            // button_Task_4_Go
            // 
            this.button_Task_4_Go.Location = new System.Drawing.Point(11, 63);
            this.button_Task_4_Go.Name = "button_Task_4_Go";
            this.button_Task_4_Go.Size = new System.Drawing.Size(75, 23);
            this.button_Task_4_Go.TabIndex = 5;
            this.button_Task_4_Go.Text = "Go";
            this.button_Task_4_Go.UseVisualStyleBackColor = true;
            this.button_Task_4_Go.Click += new System.EventHandler(this.button_Task_4_Go_Click);
            // 
            // label_Task_4_Find
            // 
            this.label_Task_4_Find.AutoSize = true;
            this.label_Task_4_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Task_4_Find.Location = new System.Drawing.Point(450, 39);
            this.label_Task_4_Find.Name = "label_Task_4_Find";
            this.label_Task_4_Find.Size = new System.Drawing.Size(40, 20);
            this.label_Task_4_Find.TabIndex = 4;
            this.label_Task_4_Find.Text = "Find";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Find";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "File full path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word";
            // 
            // textBox_Task_4_Word
            // 
            this.textBox_Task_4_Word.Location = new System.Drawing.Point(8, 36);
            this.textBox_Task_4_Word.Name = "textBox_Task_4_Word";
            this.textBox_Task_4_Word.Size = new System.Drawing.Size(100, 20);
            this.textBox_Task_4_Word.TabIndex = 1;
            this.textBox_Task_4_Word.Text = "google";
            // 
            // label_Ttask_4_Proga
            // 
            this.label_Ttask_4_Proga.AutoSize = true;
            this.label_Ttask_4_Proga.Location = new System.Drawing.Point(143, 73);
            this.label_Ttask_4_Proga.Name = "label_Ttask_4_Proga";
            this.label_Ttask_4_Proga.Size = new System.Drawing.Size(475, 13);
            this.label_Ttask_4_Proga.TabIndex = 0;
            this.label_Ttask_4_Proga.Text = "E:\\(_Work-Git_)\\ItstepSysRrogHomeWorksCSharp\\M2PHW_Zenz\\bin\\Debug\\M2PHW_Zenz.exe";
            // 
            // textBox_Task_4_FilePath
            // 
            this.textBox_Task_4_FilePath.Location = new System.Drawing.Point(146, 36);
            this.textBox_Task_4_FilePath.Name = "textBox_Task_4_FilePath";
            this.textBox_Task_4_FilePath.Size = new System.Drawing.Size(298, 20);
            this.textBox_Task_4_FilePath.TabIndex = 1;
            this.textBox_Task_4_FilePath.Text = "E:\\(_Work-Git_)\\ItstepSysRrogHomeWorksCSharp\\M2PHW\\bin\\Debug\\temp.txt";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_Res_Task_3);
            this.groupBox4.Controls.Add(this.button_Calc_Task_3);
            this.groupBox4.Controls.Add(this.nud_Left);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.nud_Right);
            this.groupBox4.Controls.Add(this.cb_OPeration);
            this.groupBox4.Controls.Add(this.label_Path_file);
            this.groupBox4.Location = new System.Drawing.Point(13, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 63);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Task 3";
            // 
            // label_Res_Task_3
            // 
            this.label_Res_Task_3.AutoSize = true;
            this.label_Res_Task_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Res_Task_3.Location = new System.Drawing.Point(143, 39);
            this.label_Res_Task_3.Name = "label_Res_Task_3";
            this.label_Res_Task_3.Size = new System.Drawing.Size(0, 20);
            this.label_Res_Task_3.TabIndex = 4;
            // 
            // button_Calc_Task_3
            // 
            this.button_Calc_Task_3.Location = new System.Drawing.Point(7, 15);
            this.button_Calc_Task_3.Name = "button_Calc_Task_3";
            this.button_Calc_Task_3.Size = new System.Drawing.Size(57, 23);
            this.button_Calc_Task_3.TabIndex = 3;
            this.button_Calc_Task_3.Text = "Calc";
            this.button_Calc_Task_3.UseVisualStyleBackColor = true;
            this.button_Calc_Task_3.Click += new System.EventHandler(this.button_Calc_Task_3_Click);
            // 
            // nud_Left
            // 
            this.nud_Left.Location = new System.Drawing.Point(70, 16);
            this.nud_Left.Name = "nud_Left";
            this.nud_Left.Size = new System.Drawing.Size(70, 20);
            this.nud_Left.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(70, 15);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // nud_Right
            // 
            this.nud_Right.Location = new System.Drawing.Point(205, 15);
            this.nud_Right.Name = "nud_Right";
            this.nud_Right.Size = new System.Drawing.Size(70, 20);
            this.nud_Right.TabIndex = 2;
            // 
            // cb_OPeration
            // 
            this.cb_OPeration.FormattingEnabled = true;
            this.cb_OPeration.Items.AddRange(new object[] {
            "/",
            "*",
            "-",
            "+"});
            this.cb_OPeration.Location = new System.Drawing.Point(146, 15);
            this.cb_OPeration.Name = "cb_OPeration";
            this.cb_OPeration.Size = new System.Drawing.Size(53, 21);
            this.cb_OPeration.TabIndex = 1;
            // 
            // label_Path_file
            // 
            this.label_Path_file.AutoSize = true;
            this.label_Path_file.Location = new System.Drawing.Point(281, 16);
            this.label_Path_file.Name = "label_Path_file";
            this.label_Path_file.Size = new System.Drawing.Size(463, 13);
            this.label_Path_file.TabIndex = 0;
            this.label_Path_file.Text = "E:\\(_Work-Git_)\\ItstepSysRrogHomeWorksCSharp\\M2PHW_Lag\\bin\\Debug\\M2PHW_Lag.exe";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Task_1_Start
            // 
            this.button_Task_1_Start.Location = new System.Drawing.Point(11, 20);
            this.button_Task_1_Start.Name = "button_Task_1_Start";
            this.button_Task_1_Start.Size = new System.Drawing.Size(336, 23);
            this.button_Task_1_Start.TabIndex = 0;
            this.button_Task_1_Start.Text = "Start Calculator";
            this.button_Task_1_Start.UseVisualStyleBackColor = true;
            this.button_Task_1_Start.Click += new System.EventHandler(this.button_Task_1_Start_Click);
            // 
            // label_Task_1_End
            // 
            this.label_Task_1_End.AutoSize = true;
            this.label_Task_1_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Task_1_End.Location = new System.Drawing.Point(416, 23);
            this.label_Task_1_End.Name = "label_Task_1_End";
            this.label_Task_1_End.Size = new System.Drawing.Size(0, 20);
            this.label_Task_1_End.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Right)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Kill_Task_2;
        private System.Windows.Forms.Label label_Codend_Task_2;
        private System.Windows.Forms.TextBox textBox_Path_Task_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Task_2_Start;
        private System.Windows.Forms.ComboBox cb_OPeration;
        private System.Windows.Forms.Label label_Path_file;
        private System.Windows.Forms.Button button_Calc_Task_3;
        private System.Windows.Forms.NumericUpDown nud_Left;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown nud_Right;
        private System.Windows.Forms.Label label_Res_Task_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Task_4_Word;
        private System.Windows.Forms.TextBox textBox_Task_4_FilePath;
        private System.Windows.Forms.Button button_Task_4_Go;
        private System.Windows.Forms.Label label_Task_4_Find;
        private System.Windows.Forms.Label label_Ttask_4_Proga;
        private System.Windows.Forms.Label label_Task_1_End;
        private System.Windows.Forms.Button button_Task_1_Start;
    }
}

