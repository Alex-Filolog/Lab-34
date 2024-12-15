using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab34
{
    public partial class GameFieldForm : Form
    {
        private const int CellSize = 20;

        private Label widthLabel = new Label();
        private Label heightLabel = new Label();

        public GameFieldForm()
        {
            InitializeComponent();
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            widthLabel = new Label
            {
                Location = new Point(10, 10),
                AutoSize = true
            };
            heightLabel = new Label
            {
                Location = new Point(10, 30),
                AutoSize = true
            };
            Controls.Add(widthLabel);
            Controls.Add(heightLabel);
        }

        private void LoadMapButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        if (lines.Length == 0)
                        {
                            MessageBox.Show("Файл пустой");
                            return;
                        }

                        int width = lines[0].Length;
                        int height = lines.Length;

                        widthLabel.Text = $"Ширина: {width}";
                        heightLabel.Text = $"Высота: {height}";

                        Controls.Clear();
                        Controls.Add(widthLabel);
                        Controls.Add(heightLabel);

                        for (int y = 0; y < height; y++)
                        {
                            if (lines[y].Length > width)
                            {
                                width = lines[y].Length;
                            }

                            for (int x = 0; x < lines[y].Length; x++)
                            {
                                char cellValue = lines[y][x];
                                if (cellValue != '#' && cellValue != ' ')
                                {
                                    MessageBox.Show("Неверные символы в файле. Ожидались '#' или ' '.");
                                    return;
                                }

                                Panel cell = new Panel
                                {
                                    Size = new Size(CellSize, CellSize),
                                    Location = new Point(x * CellSize, y * CellSize + 50),
                                    BackColor = cellValue == '#' ? Color.Green : Color.White
                                };
                                Controls.Add(cell);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}