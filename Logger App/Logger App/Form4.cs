using System;
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
    public partial class addMemberForm : Form
    {
        public addMemberForm()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && ((TextBox)control).Text == "")
                {
                    errorProvider1.SetError(insertBtn, "some boxes are left empty");
                    return;
                }
            }

            //add to database
            //...
            //...

            this.Close();
        }
    }
}
