namespace GitCommands
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            buttonCheckout = new Button();
            status_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.Location = new Point(118, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 59);
            label1.TabIndex = 0;
            label1.Text = "GIT COMMANDS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 84);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 15);
            label3.TabIndex = 2;
            label3.Text = "You can read a command descripti by clicking button";
            // 
            // button1
            // 
            button1.Location = new Point(36, 148);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(119, 28);
            button1.TabIndex = 3;
            button1.Text = "commit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCheckout
            // 
            buttonCheckout.BackColor = Color.FromArgb(243, 76, 40);
            buttonCheckout.FlatStyle = FlatStyle.Popup;
            buttonCheckout.Font = new Font("SimSun", 12.8F);
            buttonCheckout.Location = new Point(36, 179);
            buttonCheckout.Margin = new Padding(2);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(119, 28);
            buttonCheckout.TabIndex = 4;
            buttonCheckout.Text = "checkout";
            buttonCheckout.UseVisualStyleBackColor = false;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // status_btn
            // 
            status_btn.Location = new Point(36, 212);
            status_btn.Name = "status_btn";
            status_btn.Size = new Size(119, 23);
            status_btn.TabIndex = 5;
            status_btn.Text = "Status";
            status_btn.UseVisualStyleBackColor = true;
            status_btn.Click += status_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 342);
            Controls.Add(status_btn);
            Controls.Add(buttonCheckout);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button buttonCheckout;
        private Button status_btn;
    }
}
