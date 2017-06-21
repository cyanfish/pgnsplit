using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgnSplit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string Path { get; set; }

        public int PartSizeGB { get; set; }

        public bool KeepOriginal { get; set; }

        private volatile bool cancel;

        private void DoSplit()
        {
            try
            {
                PgnSplit.Split(Path, PartSizeGB * 1024 * 1024 * 1024, KeepOriginal, Progress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Invoke(new Action(Close));
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            new Thread(DoSplit).Start();
        }

        private bool Progress(long n, long total)
        {
            Invoke(new Action(() =>
            {
                int max = (int) (total / 1000);
                progressBar1.Maximum = max;
                progressBar1.Value = Math.Min(max, (int)(n / 1000));
            }));
            return !cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancel = true;
            button1.Enabled = false;
        }
    }
}
