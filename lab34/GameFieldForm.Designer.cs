namespace lab34
{
    partial class GameFieldForm
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
            panel1 = new Panel();
            LoadMapButton = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 128);
            panel1.TabIndex = 0;
            // 
            // LoadMapButton
            // 
            LoadMapButton.Location = new Point(66, 176);
            LoadMapButton.Name = "LoadMapButton";
            LoadMapButton.Size = new Size(105, 23);
            LoadMapButton.TabIndex = 0;
            LoadMapButton.Text = "Загрузить карту";
            LoadMapButton.UseVisualStyleBackColor = true;
            LoadMapButton.Click += LoadMapButton_Click;
            // 
            // GameFieldForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(LoadMapButton);
            Controls.Add(panel1);
            Name = "GameFieldForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игровое поле";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LoadMapButton;
    }
}