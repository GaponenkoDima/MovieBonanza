using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// SplashScreenForm.cs
/// Author: Dmytro Gaponenko
/// Student ID: 200335210
/// Date: March 05, 2017
/// </summary>
namespace MovieBonanza
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
                SelectionForm selectionForm = new SelectionForm();
                this.SplashScreenTimer.Enabled = false;
                selectionForm.Show();
                this.Hide();
        }
    }
}