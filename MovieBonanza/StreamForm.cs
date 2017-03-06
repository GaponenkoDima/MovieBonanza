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
/// StreamForm.cs
/// Author: Dmytro Gaponenko
/// Student ID: 200335210
/// Date: March 05, 2017
/// </summary>
namespace MovieBonanza
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Thank you for choosing Movie Bonanza!" + "\r\n" 
                + "Your Credit card will be charged " + OrderForm1.total.ToString("C2") + "\r\n" + Program.movie.Title + "will begin streaming shortly" ;
        }

        private void StreamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
