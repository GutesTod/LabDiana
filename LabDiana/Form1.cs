using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabDiana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] asciiBytes;

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (asciiBytes == null)
            {
                return;
            }
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i] = (byte)(((byte)(asciiBytes[i] + ((byte)numericUpDownKey.Value))) % 256);
            }
            System.IO.File.WriteAllText(pathToFile.Text, System.Text.Encoding.UTF8.GetString(asciiBytes));
            lblResult.Text = "Ўифрование прошло успешно: " + System.Text.Encoding.UTF8.GetString(asciiBytes);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            pathToFile.Text = filename;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            asciiBytes = Encoding.UTF8.GetBytes(fileText);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (asciiBytes == null)
            {
                return;
            }
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                asciiBytes[i] = (byte)(((byte)(asciiBytes[i] - ((byte)numericUpDownKey.Value))) % 256);
            }
            System.IO.File.WriteAllText(pathToFile.Text, System.Text.Encoding.UTF8.GetString(asciiBytes));
            lblResult.Text = "ƒешифрование прошло успешно: " + System.Text.Encoding.UTF8.GetString(asciiBytes);
        }

        private void numericUpDownKey_ValueChanged(object sender, EventArgs e)
        {
            if ((numericUpDownKey.Value < 0))
            {
                numericUpDownKey.Value = 0;
            }
            if ((numericUpDownKey.Value > 255))
            {
                numericUpDownKey.Value = 255;
            }
        }
    }
}