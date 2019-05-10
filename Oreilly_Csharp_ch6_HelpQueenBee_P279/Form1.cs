using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WorkerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing","Egg care",
                "Baby bee tutoring","Hive maintenance","Sting patrol" }, 155);
            queen = new Queen(workers,275);

        }
        private Queen queen;

        private void AssignButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(WorkerBeeJob.Text, (int)Shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + WorkerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + WorkerBeeJob.Text + "' will be done in " + Shifts.Value + " shifts", "The queen bee says...");
        }

        private void NextShift_Click(object sender, EventArgs e)
        {
            Report.Text = queen.WorkTheNextShift();
        }
    }
}