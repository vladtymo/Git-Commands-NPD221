namespace GitCommands
{
    partial class YouTubeLinkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeLinkForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(575, 25);
            label1.TabIndex = 0;
            label1.Text = "Git – Ветки – Команда checkout при незакоммиченных изменениях";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(15, 37);
            button1.Name = "button1";
            button1.Size = new Size(167, 41);
            button1.TabIndex = 1;
            button1.Text = "YouTube";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(15, 132);
            button2.Name = "button2";
            button2.Size = new Size(167, 41);
            button2.TabIndex = 2;
            button2.Text = "YouTube";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 10.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 104);
            label2.Name = "label2";
            label2.Size = new Size(437, 25);
            label2.TabIndex = 3;
            label2.Text = "Разбираемся как ходить по комиттам git: checkout";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(15, 227);
            button3.Name = "button3";
            button3.Size = new Size(167, 41);
            button3.TabIndex = 4;
            button3.Text = "YouTube";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(544, 25);
            label3.TabIndex = 5;
            label3.Text = "Что такое Git для Начинающих / GitHub за 30 минут / Git Уроки";
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(15, 321);
            button4.Name = "button4";
            button4.Size = new Size(167, 41);
            button4.TabIndex = 6;
            button4.Text = "YouTube";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 10.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 293);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 7;
            label4.Text = "Git и GitHub для новичков";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 10.8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 385);
            label5.Name = "label5";
            label5.Size = new Size(281, 25);
            label5.TabIndex = 8;
            label5.Text = "Git и GitHub Курс Для Новичков";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 11F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(15, 413);
            button5.Name = "button5";
            button5.Size = new Size(167, 41);
            button5.TabIndex = 9;
            button5.Text = "YouTube";
            button5.UseVisualStyleBackColor = false;
            // 
            // YouTubeLinkForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 48);
            ClientSize = new Size(800, 489);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YouTubeLinkForm";
            Text = "YouTube Link";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Button button5;
    }
}