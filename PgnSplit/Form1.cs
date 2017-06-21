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
            new Form2
            {
                Path = txtFile.Text,
                PartSizeGB = int.TryParse(txtPartSize.Text, out int value) ? value : 1,
                KeepOriginal = cbKeepOriginal.Checked
            }.ShowDialog();
        }
    }
}
