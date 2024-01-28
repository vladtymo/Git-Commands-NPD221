namespace GitCommands
{
    partial class CommitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitForm));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(172, 62);
            label1.Name = "label1";
            label1.Size = new Size(866, 78);
            label1.TabIndex = 0;
            label1.Text = "Commit Commands Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 237);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(1138, 262);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 525);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1138, 577);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(473, 1135);
            button1.Name = "button1";
            button1.Size = new Size(289, 59);
            button1.TabIndex = 3;
            button1.Text = "Read More";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CommitForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 1246);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CommitForm";
            Text = "CommitForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}