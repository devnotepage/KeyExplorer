﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExplorer
{
    public partial class MainForm : Form
    {
        private Canvas canvas = null;
        public MainForm()
        {
            InitializeComponent();
            canvas = new Canvas(this.pictureBoxMain);
            canvas.Draw();
        }
    }
}