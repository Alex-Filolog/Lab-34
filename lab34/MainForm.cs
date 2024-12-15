namespace lab34
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenTimeFormButton_Click(object sender, EventArgs e)
        {
            TimeForm timeForm = new TimeForm();
            timeForm.Show();
        }
        private void OpenAnimationFormButton_Click(object sender, EventArgs e)
        {
            AnimationForm animationForm = new AnimationForm();
            animationForm.Show();
        }
        private void OpenGameFieldFormButton_Click(object sender, EventArgs e)
        {
            GameFieldForm gameFieldForm = new GameFieldForm();
            gameFieldForm.Show();
        }
    }
}