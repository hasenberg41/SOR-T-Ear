namespace Visualization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FillTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 48);
            this.panel1.TabIndex = 0;
            // 
            // AddTextBox1
            // 
            this.AddTextBox1.Location = new System.Drawing.Point(3, 21);
            this.AddTextBox1.Name = "AddTextBox1";
            this.AddTextBox1.Size = new System.Drawing.Size(230, 20);
            this.AddTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить число";
            // 
            // AddButton1
            // 
            this.AddButton1.Location = new System.Drawing.Point(239, 19);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(75, 23);
            this.AddButton1.TabIndex = 0;
            this.AddButton1.Text = "Добавить";
            this.AddButton1.UseVisualStyleBackColor = true;
            this.AddButton1.Click += new System.EventHandler(this.AddButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FillTextBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Location = new System.Drawing.Point(5, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 48);
            this.panel2.TabIndex = 1;
            // 
            // FillTextBox1
            // 
            this.FillTextBox1.Location = new System.Drawing.Point(3, 21);
            this.FillTextBox1.Name = "FillTextBox1";
            this.FillTextBox1.Size = new System.Drawing.Size(230, 20);
            this.FillTextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заполнить случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(239, 19);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 0;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(330, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 102);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 259);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AddTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FillTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Panel panel3;
    }
}

