using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgnSplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbSizeUnit.SelectedItem = "GB";
        }

        private void btnFilePrompt_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                FileName = "",
                Filter = "PGN Files (*.pgn)|*.pgn"
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            txtFile.Text = dialog.FileName;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            int partSizeValue = int.TryParse(txtPartSize.Text, out int value) ? value : 1;
            long partSize = 1024 * 1024 * partSizeValue;
            if (cbSizeUnit.Text == "GB")
            {
                partSize *= 1024;
            }
            new Form2
            {
                Path = txtFile.Text,
                PartSize = partSize,
                KeepOriginal = cbKeepOriginal.Checked
            }.ShowDialog();
        }
    }
}
