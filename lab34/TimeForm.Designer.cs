namespace lab34
{
    partial class TimeForm
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
            StartButton = new Button();
            PauseButton = new Button();
            TimeUpdateTimer = new System.Windows.Forms.Timer(components);
            TimeLabel = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Старт";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // PauseButton
            // 
            PauseButton.Location = new Point(93, 12);
            PauseButton.Name = "PauseButton";
            PauseButton.Size = new Size(75, 23);
            PauseButton.TabIndex = 1;
            PauseButton.Text = "Пауза";
            PauseButton.UseVisualStyleBackColor = true;
            PauseButton.Click += PauseButton_Click;
            // 
            // TimeUpdateTimer
            // 
            TimeUpdateTimer.Interval = 1000;
            TimeUpdateTimer.Tick += TimeUpdateTimer_Tick;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(71, 38);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(34, 15);
            TimeLabel.TabIndex = 2;
            TimeLabel.Text = "00:00";
            // 
            // TimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 68);
            Controls.Add(TimeLabel);
            Controls.Add(PauseButton);
            Controls.Add(StartButton);
            Name = "TimeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Время";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button PauseButton;
        private System.Windows.Forms.Timer TimeUpdateTimer;
        private Label TimeLabel;
    }
}