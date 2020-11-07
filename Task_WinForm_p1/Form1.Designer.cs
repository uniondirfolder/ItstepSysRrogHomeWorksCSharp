namespace Task_WinForm_p1
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
            this.button_Task_1 = new System.Windows.Forms.Button();
            this.textBox_Task_1 = new System.Windows.Forms.TextBox();
            this.button_Task_2 = new System.Windows.Forms.Button();
            this.textBox_Task_2 = new System.Windows.Forms.TextBox();
            this.numericUpDown_Task_2_Min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Task2_Max = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Task_3 = new System.Windows.Forms.CheckBox();
            this.textBox_Task_3 = new System.Windows.Forms.TextBox();
            this.button_Task_4 = new System.Windows.Forms.Button();
            this.checkBox_Task_5 = new System.Windows.Forms.CheckBox();
            this.textBox_Task_4 = new System.Windows.Forms.TextBox();
            this.label_Min = new System.Windows.Forms.Label();
            this.label_Max = new System.Windows.Forms.Label();
            this.label_Avg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Task_2_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Task2_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Task_1
            // 
            this.button_Task_1.Location = new System.Drawing.Point(13, 13);
            this.button_Task_1.Name = "button_Task_1";
            this.button_Task_1.Size = new System.Drawing.Size(100, 23);
            this.button_Task_1.TabIndex = 0;
            this.button_Task_1.Text = "Task 1";
            this.button_Task_1.UseVisualStyleBackColor = true;
            this.button_Task_1.Click += new System.EventHandler(this.button_Task_1_Click);
            // 
            // textBox_Task_1
            // 
            this.textBox_Task_1.Location = new System.Drawing.Point(13, 43);
            this.textBox_Task_1.Multiline = true;
            this.textBox_Task_1.Name = "textBox_Task_1";
            this.textBox_Task_1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Task_1.Size = new System.Drawing.Size(100, 197);
            this.textBox_Task_1.TabIndex = 1;
            // 
            // button_Task_2
            // 
            this.button_Task_2.Location = new System.Drawing.Point(119, 13);
            this.button_Task_2.Name = "button_Task_2";
            this.button_Task_2.Size = new System.Drawing.Size(100, 23);
            this.button_Task_2.TabIndex = 0;
            this.button_Task_2.Text = "Task 2";
            this.button_Task_2.UseVisualStyleBackColor = true;
            this.button_Task_2.Click += new System.EventHandler(this.button_Task_2_Click);
            // 
            // textBox_Task_2
            // 
            this.textBox_Task_2.Location = new System.Drawing.Point(119, 43);
            this.textBox_Task_2.Multiline = true;
            this.textBox_Task_2.Name = "textBox_Task_2";
            this.textBox_Task_2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Task_2.Size = new System.Drawing.Size(100, 197);
            this.textBox_Task_2.TabIndex = 1;
            // 
            // numericUpDown_Task_2_Min
            // 
            this.numericUpDown_Task_2_Min.Location = new System.Drawing.Point(226, 15);
            this.numericUpDown_Task_2_Min.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Task_2_Min.Name = "numericUpDown_Task_2_Min";
            this.numericUpDown_Task_2_Min.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_Task_2_Min.TabIndex = 2;
            // 
            // numericUpDown_Task2_Max
            // 
            this.numericUpDown_Task2_Max.Location = new System.Drawing.Point(226, 41);
            this.numericUpDown_Task2_Max.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Task2_Max.Name = "numericUpDown_Task2_Max";
            this.numericUpDown_Task2_Max.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_Task2_Max.TabIndex = 2;
            this.numericUpDown_Task2_Max.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // checkBox_Task_3
            // 
            this.checkBox_Task_3.AutoSize = true;
            this.checkBox_Task_3.Location = new System.Drawing.Point(286, 17);
            this.checkBox_Task_3.Name = "checkBox_Task_3";
            this.checkBox_Task_3.Size = new System.Drawing.Size(127, 17);
            this.checkBox_Task_3.TabIndex = 3;
            this.checkBox_Task_3.Text = "Show_Thread_Count";
            this.checkBox_Task_3.UseVisualStyleBackColor = true;
            this.checkBox_Task_3.CheckedChanged += new System.EventHandler(this.checkBox_Task_3_CheckedChanged);
            // 
            // textBox_Task_3
            // 
            this.textBox_Task_3.Location = new System.Drawing.Point(286, 40);
            this.textBox_Task_3.Multiline = true;
            this.textBox_Task_3.Name = "textBox_Task_3";
            this.textBox_Task_3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Task_3.Size = new System.Drawing.Size(127, 197);
            this.textBox_Task_3.TabIndex = 1;
            // 
            // button_Task_4
            // 
            this.button_Task_4.Location = new System.Drawing.Point(436, 13);
            this.button_Task_4.Name = "button_Task_4";
            this.button_Task_4.Size = new System.Drawing.Size(116, 23);
            this.button_Task_4.TabIndex = 4;
            this.button_Task_4.Text = "Task_4";
            this.button_Task_4.UseVisualStyleBackColor = true;
            this.button_Task_4.Click += new System.EventHandler(this.button_Task_4_Click);
            // 
            // checkBox_Task_5
            // 
            this.checkBox_Task_5.AutoSize = true;
            this.checkBox_Task_5.Location = new System.Drawing.Point(558, 19);
            this.checkBox_Task_5.Name = "checkBox_Task_5";
            this.checkBox_Task_5.Size = new System.Drawing.Size(107, 17);
            this.checkBox_Task_5.TabIndex = 3;
            this.checkBox_Task_5.Text = "Write result to file";
            this.checkBox_Task_5.UseVisualStyleBackColor = true;
            this.checkBox_Task_5.CheckedChanged += new System.EventHandler(this.checkBox_Task_5_CheckedChanged);
            // 
            // textBox_Task_4
            // 
            this.textBox_Task_4.Location = new System.Drawing.Point(436, 40);
            this.textBox_Task_4.Multiline = true;
            this.textBox_Task_4.Name = "textBox_Task_4";
            this.textBox_Task_4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Task_4.Size = new System.Drawing.Size(144, 197);
            this.textBox_Task_4.TabIndex = 1;
            // 
            // label_Min
            // 
            this.label_Min.AutoSize = true;
            this.label_Min.Location = new System.Drawing.Point(587, 43);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(0, 13);
            this.label_Min.TabIndex = 5;
            // 
            // label_Max
            // 
            this.label_Max.AutoSize = true;
            this.label_Max.Location = new System.Drawing.Point(587, 65);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(0, 13);
            this.label_Max.TabIndex = 5;
            // 
            // label_Avg
            // 
            this.label_Avg.AutoSize = true;
            this.label_Avg.Location = new System.Drawing.Point(587, 87);
            this.label_Avg.Name = "label_Avg";
            this.label_Avg.Size = new System.Drawing.Size(0, 13);
            this.label_Avg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 266);
            this.Controls.Add(this.label_Avg);
            this.Controls.Add(this.label_Max);
            this.Controls.Add(this.label_Min);
            this.Controls.Add(this.button_Task_4);
            this.Controls.Add(this.checkBox_Task_5);
            this.Controls.Add(this.checkBox_Task_3);
            this.Controls.Add(this.numericUpDown_Task2_Max);
            this.Controls.Add(this.numericUpDown_Task_2_Min);
            this.Controls.Add(this.textBox_Task_4);
            this.Controls.Add(this.textBox_Task_3);
            this.Controls.Add(this.textBox_Task_2);
            this.Controls.Add(this.button_Task_2);
            this.Controls.Add(this.textBox_Task_1);
            this.Controls.Add(this.button_Task_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Task_2_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Task2_Max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Task_1;
        private System.Windows.Forms.TextBox textBox_Task_1;
        private System.Windows.Forms.Button button_Task_2;
        private System.Windows.Forms.TextBox textBox_Task_2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Task_2_Min;
        private System.Windows.Forms.NumericUpDown numericUpDown_Task2_Max;
        private System.Windows.Forms.CheckBox checkBox_Task_3;
        private System.Windows.Forms.TextBox textBox_Task_3;
        private System.Windows.Forms.Button button_Task_4;
        private System.Windows.Forms.CheckBox checkBox_Task_5;
        private System.Windows.Forms.TextBox textBox_Task_4;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Max;
        private System.Windows.Forms.Label label_Avg;
    }
}

