﻿using System;
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
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing","Egg care",
                "Baby bee tutoring","Hive maintenance","Sting patrol" });
        }   queen = new Queen (workers);
    }
}
