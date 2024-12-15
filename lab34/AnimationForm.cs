using System;
using System.Windows.Forms;

namespace lab34
{
    public partial class AnimationForm : Form
    {
        public AnimationForm()
        {
            InitializeComponent();
        }

        private int currentFrame = 0;

        private void AnimationForm_Load(object sender, EventArgs e)
        {
            CharacterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterAnimationTimer.Start();
        }

        private void CharacterAnimationTimer_Tick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % CharacterImagesList.Images.Count;
            CharacterPictureBox.Image = CharacterImagesList.Images[currentFrame];
        }
    }
}