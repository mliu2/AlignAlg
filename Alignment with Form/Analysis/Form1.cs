using GlobalLocalAlignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // remove whitespace and prepend a - to contents of seq
            char[] first = ("-" + Regex.Replace(seq1.Text, @"\s+", "").ToUpper()).ToCharArray();
            char[] second = ("-" + Regex.Replace(seq2.Text, @"\s+", "").ToUpper()).ToCharArray();

            if (isGlobal.Checked)
            {
                // global alignment

            }
            else if (isLocal.Checked)
            {
                // local alignment

            }
            else
            {
                // alignment type options not selected
                results.Text = "Please select if this alignment should be global or local";
                return;
            }

            if (countGaps.Checked)
            {
                // gaps should be counted
            }
            else if (countNoGaps.Checked)
            {
                // gaps should NOT be counted
            }
            else
            {
                // gap options not selected
                results.Text = "Please select if this alignment should count gaps or not";
                return;
            }

            ScoringMatrix simon = new ScoringMatrix(first, second);
            OptimumMatrix jack = new OptimumMatrix(first, second);

            for (int i = 1; i < first.Length; i++)
            {
                for (int j = 1; j < second.Length; j++)
                {
                    jack.setScore(i, j, simon.calcCell(i, j));
                }
            }
            int[] maxPos = simon.getMaxScorePos();
            string[] paul = jack.calcOptPathFrom(maxPos[0], maxPos[1]);
            results.Text += paul[0] + "\r\n" + paul[1]; 
        }
    }
}
