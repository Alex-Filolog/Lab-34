namespace lab34
{
    partial class AnimationForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationForm));
            CharacterAnimationTimer = new System.Windows.Forms.Timer(components);
            CharacterImagesList = new ImageList(components);
            CharacterPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CharacterPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CharacterAnimationTimer
            // 
            CharacterAnimationTimer.Tick += CharacterAnimationTimer_Tick;
            // 
            // CharacterImagesList
            // 
            CharacterImagesList.ColorDepth = ColorDepth.Depth32Bit;
            CharacterImagesList.ImageStream = (ImageListStreamer)resources.GetObject("CharacterImagesList.ImageStream");
            CharacterImagesList.TransparentColor = Color.Transparent;
            CharacterImagesList.Images.SetKeyName(0, "charlieTheCapybaraAnimationSheet (1).png");
            CharacterImagesList.Images.SetKeyName(1, "charlieTheCapybaraAnimationSheet (2).png");
            CharacterImagesList.Images.SetKeyName(2, "charlieTheCapybaraAnimationSheet (3).png");
            CharacterImagesList.Images.SetKeyName(3, "charlieTheCapybaraAnimationSheet (4).png");
            CharacterImagesList.Images.SetKeyName(4, "charlieTheCapybaraAnimationSheet (5).png");
            CharacterImagesList.Images.SetKeyName(5, "charlieTheCapybaraAnimationSheet (6).png");
            CharacterImagesList.Images.SetKeyName(6, "charlieTheCapybaraAnimationSheet (7).png");
            CharacterImagesList.Images.SetKeyName(7, "charlieTheCapybaraAnimationSheet (8).png");
            // 
            // CharacterPictureBox
            // 
            CharacterPictureBox.Image = (Image)resources.GetObject("CharacterPictureBox.Image");
            CharacterPictureBox.Location = new Point(39, 12);
            CharacterPictureBox.Name = "CharacterPictureBox";
            CharacterPictureBox.Size = new Size(36, 35);
            CharacterPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CharacterPictureBox.TabIndex = 0;
            CharacterPictureBox.TabStop = false;
            // 
            // AnimationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 73);
            Controls.Add(CharacterPictureBox);
            Name = "AnimationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анимация";
            Load += AnimationForm_Load;
            ((System.ComponentModel.ISupportInitialize)CharacterPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer CharacterAnimationTimer;
        private ImageList CharacterImagesList;
        private PictureBox CharacterPictureBox;
    }
}