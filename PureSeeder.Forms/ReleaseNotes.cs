﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATRGamers.ATRSeeder.Forms.Properties;

namespace ATRGamers.ATRSeeder.Forms
{
    public partial class ReleaseNotes : Form
    {
        public ReleaseNotes()
        {
            InitializeComponent();
        }

        private void ReleaseNotes_Load(object sender, EventArgs e)
        {
            Icon = Resources.PB;
            webBrowser1.Url = new Uri("http://atrstats.com/seeder/releasenotes");
        }
    }
}
