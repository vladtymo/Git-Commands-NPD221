namespace GitCommands
{
    partial class CommitCheckoutForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitCheckoutForms));
            labelMainInfo = new Label();
            labelChatGPT = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonYouTube = new Button();
            label2 = new Label();
            buttonSite = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelMainInfo
            // 
            labelMainInfo.AutoSize = true;
            labelMainInfo.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMainInfo.Location = new Point(91, 9);
            labelMainInfo.Name = "labelMainInfo";
            labelMainInfo.Size = new Size(626, 52);
            labelMainInfo.TabIndex = 0;
            labelMainInfo.Text = "Одна із основних команд \"git checkout\"";
            // 
            // labelChatGPT
            // 
            labelChatGPT.AutoSize = true;
            labelChatGPT.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChatGPT.Location = new Point(12, 76);
            labelChatGPT.Name = "labelChatGPT";
            labelChatGPT.Size = new Size(172, 22);
            labelChatGPT.TabIndex = 1;
            labelChatGPT.Text = "Інфа від ChatGPT";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11F);
            label1.Location = new Point(13, 304);
            label1.Name = "label1";
            label1.Size = new Size(306, 33);
            label1.TabIndex = 3;
            label1.Text = "Відео на тему \"git checkout\"";
            // 
            // buttonYouTube
            // 
            buttonYouTube.BackColor = Color.Red;
            buttonYouTube.FlatStyle = FlatStyle.Popup;
            buttonYouTube.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonYouTube.ForeColor = Color.White;
            buttonYouTube.Location = new Point(13, 340);
            buttonYouTube.Name = "buttonYouTube";
            buttonYouTube.Size = new Size(145, 42);
            buttonYouTube.TabIndex = 4;
            buttonYouTube.Text = "Click";
            buttonYouTube.UseVisualStyleBackColor = false;
            buttonYouTube.Click += buttonYouTube_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11F);
            label2.Location = new Point(12, 403);
            label2.Name = "label2";
            label2.Size = new Size(420, 33);
            label2.TabIndex = 5;
            label2.Text = "Інформацією про команду \"git checkout\"";
            // 
            // buttonSite
            // 
            buttonSite.BackColor = Color.FromArgb(243, 76, 40);
            buttonSite.FlatStyle = FlatStyle.Popup;
            buttonSite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSite.ForeColor = Color.White;
            buttonSite.Location = new Point(13, 439);
            buttonSite.Name = "buttonSite";
            buttonSite.Size = new Size(145, 42);
            buttonSite.TabIndex = 6;
            buttonSite.Text = "Click";
            buttonSite.UseVisualStyleBackColor = false;
            buttonSite.Click += buttonSite_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(537, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(251, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // CommitCheckoutForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 506);
            Controls.Add(pictureBox2);
            Controls.Add(buttonSite);
            Controls.Add(label2);
            Controls.Add(buttonYouTube);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelChatGPT);
            Controls.Add(labelMainInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CommitCheckoutForms";
            Text = "GitHub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMainInfo;
        private Label labelChatGPT;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonYouTube;
        private Label label2;
        private Button buttonSite;
        private PictureBox pictureBox2;
    }
}