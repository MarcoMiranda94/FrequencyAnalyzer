using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void cmdAnalyze_Click(object sender, EventArgs e)
        {
            FormFrequency ff = new FormFrequency();
            ff.text = txtText.Text;
            ff.Show();
        }
    }
}
