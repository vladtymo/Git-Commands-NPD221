namespace GitCommands
{
    partial class TagForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagForm));
            TagLbl = new Label();
            TagTB = new TextBox();
            TagPB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TagPB).BeginInit();
            SuspendLayout();
            // 
            // TagLbl
            // 
            TagLbl.AutoSize = true;
            TagLbl.Font = new Font("Segoe UI", 32F);
            TagLbl.Location = new Point(247, 39);
            TagLbl.Name = "TagLbl";
            TagLbl.Size = new Size(311, 59);
            TagLbl.TabIndex = 0;
            TagLbl.Text = "Tag description";
            // 
            // TagTB
            // 
            TagTB.Location = new Point(266, 134);
            TagTB.Multiline = true;
            TagTB.Name = "TagTB";
            TagTB.ReadOnly = true;
            TagTB.ScrollBars = ScrollBars.Both;
            TagTB.Size = new Size(492, 172);
            TagTB.TabIndex = 1;
            TagTB.Text = resources.GetString("TagTB.Text");
            // 
            // TagPB
            // 
            TagPB.Image = (Image)resources.GetObject("TagPB.Image");
            TagPB.Location = new Point(12, 110);
            TagPB.Name = "TagPB";
            TagPB.Size = new Size(235, 260);
            TagPB.SizeMode = PictureBoxSizeMode.Zoom;
            TagPB.TabIndex = 2;
            TagPB.TabStop = false;
            // 
            // TagForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TagPB);
            Controls.Add(TagTB);
            Controls.Add(TagLbl);
            Name = "TagForm";
            Text = "TagForm";
            ((System.ComponentModel.ISupportInitialize)TagPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TagLbl;
        private TextBox TagTB;
        private PictureBox TagPB;
    }
}