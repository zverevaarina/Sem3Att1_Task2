namespace Att_task2
{
    partial class FormMain
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
            this.labelName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelFirmInfo = new System.Windows.Forms.Label();
            this.textBoxName_2 = new System.Windows.Forms.TextBox();
            this.textBoxInvestments_2 = new System.Windows.Forms.TextBox();
            this.textBoxRating_2 = new System.Windows.Forms.TextBox();
            this.labelName_2 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelQ = new System.Windows.Forms.Label();
            this.labelQp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(138, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Доход:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(141, 81);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(100, 22);
            this.textBoxIncome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Рейтинг:";
            this.label1.Click += new System.EventHandler(this.labelRating_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(268, 81);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 22);
            this.textBoxRating.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Q:";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(399, 249);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "P:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Qp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Firm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Investments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Название:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Доход:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Рейтинг:";
            // 
            // labelFirmInfo
            // 
            this.labelFirmInfo.AutoSize = true;
            this.labelFirmInfo.Location = new System.Drawing.Point(9, 119);
            this.labelFirmInfo.Name = "labelFirmInfo";
            this.labelFirmInfo.Size = new System.Drawing.Size(13, 17);
            this.labelFirmInfo.TabIndex = 18;
            this.labelFirmInfo.Text = "-";
            // 
            // textBoxName_2
            // 
            this.textBoxName_2.Location = new System.Drawing.Point(12, 249);
            this.textBoxName_2.Name = "textBoxName_2";
            this.textBoxName_2.Size = new System.Drawing.Size(100, 22);
            this.textBoxName_2.TabIndex = 19;
            // 
            // textBoxInvestments_2
            // 
            this.textBoxInvestments_2.Location = new System.Drawing.Point(141, 249);
            this.textBoxInvestments_2.Name = "textBoxInvestments_2";
            this.textBoxInvestments_2.Size = new System.Drawing.Size(100, 22);
            this.textBoxInvestments_2.TabIndex = 19;
            // 
            // textBoxRating_2
            // 
            this.textBoxRating_2.Location = new System.Drawing.Point(268, 249);
            this.textBoxRating_2.Name = "textBoxRating_2";
            this.textBoxRating_2.Size = new System.Drawing.Size(100, 22);
            this.textBoxRating_2.TabIndex = 19;
            // 
            // labelName_2
            // 
            this.labelName_2.AutoSize = true;
            this.labelName_2.Location = new System.Drawing.Point(12, 292);
            this.labelName_2.Name = "labelName_2";
            this.labelName_2.Size = new System.Drawing.Size(13, 17);
            this.labelName_2.TabIndex = 20;
            this.labelName_2.Text = "-";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(443, 61);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(113, 146);
            this.buttonRun.TabIndex = 21;
            this.buttonRun.Text = "Посчитать";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(396, 81);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(13, 17);
            this.labelQ.TabIndex = 22;
            this.labelQ.Text = "-";
            // 
            // labelQp
            // 
            this.labelQp.AutoSize = true;
            this.labelQp.Location = new System.Drawing.Point(525, 254);
            this.labelQp.Name = "labelQp";
            this.labelQp.Size = new System.Drawing.Size(13, 17);
            this.labelQp.TabIndex = 22;
            this.labelQp.Text = "-";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 349);
            this.Controls.Add(this.labelQp);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelName_2);
            this.Controls.Add(this.textBoxInvestments_2);
            this.Controls.Add(this.textBoxRating_2);
            this.Controls.Add(this.textBoxName_2);
            this.Controls.Add(this.labelFirmInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelFirmInfo;
        private System.Windows.Forms.TextBox textBoxName_2;
        private System.Windows.Forms.TextBox textBoxInvestments_2;
        private System.Windows.Forms.TextBox textBoxRating_2;
        private System.Windows.Forms.Label labelName_2;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label labelQp;
    }
}

