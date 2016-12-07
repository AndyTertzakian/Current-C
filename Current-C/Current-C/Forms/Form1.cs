/*
 *
 *Author: Andre Tertzakian
 *  Date: December, 2016 
 * 
 */

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Current_C.Utility;

namespace Current_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = (InternetUtility.InternetConnected()) ? "Connected" : "Not Connected";
        }
    }
}
