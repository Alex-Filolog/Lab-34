namespace lab34
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
            OpenTimeFormButton = new Button();
            OpenAnimationFormButton = new Button();
            OpenGameFieldFormButton = new Button();
            SuspendLayout();
            // 
            // OpenTimeFormButton
            // 
            OpenTimeFormButton.Location = new Point(10, 12);
            OpenTimeFormButton.Name = "OpenTimeFormButton";
            OpenTimeFormButton.Size = new Size(104, 23);
            OpenTimeFormButton.TabIndex = 0;
            OpenTimeFormButton.Text = "Показать время";
            OpenTimeFormButton.UseVisualStyleBackColor = true;
            OpenTimeFormButton.Click += OpenTimeFormButton_Click;
            // 
            // OpenAnimationFormButton
            // 
            OpenAnimationFormButton.Location = new Point(120, 12);
            OpenAnimationFormButton.Name = "OpenAnimationFormButton";
            OpenAnimationFormButton.Size = new Size(75, 23);
            OpenAnimationFormButton.TabIndex = 1;
            OpenAnimationFormButton.Text = "Анимация";
            OpenAnimationFormButton.UseVisualStyleBackColor = true;
            OpenAnimationFormButton.Click += OpenAnimationFormButton_Click;
            // 
            // OpenGameFieldFormButton
            // 
            OpenGameFieldFormButton.Location = new Point(201, 12);
            OpenGameFieldFormButton.Name = "OpenGameFieldFormButton";
            OpenGameFieldFormButton.Size = new Size(101, 23);
            OpenGameFieldFormButton.TabIndex = 2;
            OpenGameFieldFormButton.Text = "Игровое поле";
            OpenGameFieldFormButton.UseVisualStyleBackColor = true;
            OpenGameFieldFormButton.Click += OpenGameFieldFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 47);
            Controls.Add(OpenGameFieldFormButton);
            Controls.Add(OpenAnimationFormButton);
            Controls.Add(OpenTimeFormButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            ResumeLayout(false);
        }

        #endregion

        private Button OpenTimeFormButton;
        private Button OpenAnimationFormButton;
        private Button OpenGameFieldFormButton;
    }
}
