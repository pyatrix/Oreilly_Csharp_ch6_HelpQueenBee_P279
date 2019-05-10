using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//引用DLL申明

namespace Oreilly_Csharp_ch6_HelpQueenBee_P279
{
    public partial class Form1 : Form
    {
        //DLL申明
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        }

        //DLL申明
        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern void DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS
        margins);

        //DLL申明
        [DllImport("dwmapi.dll", PreserveSig = false)]
        static extern bool DwmIsCompositionEnabled();

        protected override void OnLoad(EventArgs e)
        {
            if (DwmIsCompositionEnabled())
            {
                MARGINS margins = new MARGINS();
                margins.Right = margins.Left = margins.Top = margins.Bottom =
        this.Width + this.Height;
                DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
            base.OnLoad(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black);
            }
        }
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