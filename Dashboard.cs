﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            var newForm = new EventDashboard();
            newForm.Show();
        }
    }
}