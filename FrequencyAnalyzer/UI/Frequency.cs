using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analyzer;

namespace UI
{
    public partial class FormFrequency : Form
    {
        public String text { get; set; }
        private Analyze an = new Analyze();
        public FormFrequency()
        {
            InitializeComponent();
        }

        private void FormFrequency_Load(object sender, EventArgs e)
        {
            an.analize(text);
            List<Letter> list = an.getList();
            for (int i = 0; i < list.Count; i++)
			{
                if (list[i].value != ' ')
                    chartFrequencyLetters.Series["Letter"].Points.AddXY(list[i].value + "", list[i].count); 
                else
                    chartFrequencyLetters.Series["Letter"].Points.AddXY("Space", list[i].count); 
			}
            chartFrequencyLetters.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartFrequencyLetters.ChartAreas["ChartArea1"].AxisY.Interval = 1;
            

            
        }
    }
}
