namespace GitCommands
{
    partial class MergeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeForm));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            readMoreBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(395, 37);
            label1.TabIndex = 0;
            label1.Text = "Merge Command Description";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 85);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(12, 244);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(494, 85);
            textBox2.TabIndex = 2;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(12, 433);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(494, 85);
            textBox3.TabIndex = 3;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(160, 335);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // readMoreBtn
            // 
            readMoreBtn.Location = new Point(192, 535);
            readMoreBtn.Name = "readMoreBtn";
            readMoreBtn.Size = new Size(116, 30);
            readMoreBtn.TabIndex = 6;
            readMoreBtn.Text = "Read More...";
            readMoreBtn.UseVisualStyleBackColor = true;
            readMoreBtn.Click += readMoreBtn_Click;
            // 
            // MergeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(518, 591);
            Controls.Add(readMoreBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "MergeForm";
            Text = "MergeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button readMoreBtn;
    }
}