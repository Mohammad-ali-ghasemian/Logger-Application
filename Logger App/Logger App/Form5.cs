﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger_App
{
    public partial class removeUserForm : Form
    {
        public removeUserForm()
        {
            InitializeComponent();
        }

        private void removeUserDgv_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //remove user from database
            //log
            //...
            //...
        }
    }
}
