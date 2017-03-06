using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// OrderForm1.cs
/// Author: Dmytro Gaponenko
/// Student ID: 200335210
/// Date: March 05, 2017
/// </summary>
namespace MovieBonanza
{
    public partial class OrderForm1 : Form
    {
        public static double total;
        public SelectionForm previousForm;
        private PrintDocument printDocument1 = new PrintDocument();
        private Bitmap memoryImage;

        public OrderForm1()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        //printing page from drawing
        private void printDocument1_PrintPage(System.Object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TextBoxTitle.Text = Program.movie.Title;
            TextBoxCategory.Text = Program.movie.Category;
            TextBoxCost.Text = Program.movie.Cost;
            PictureBoxMovieSelected.Image = Program.movie.Picture;
            calculate();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Movie movie = Program.movie;
            movie.Title = TextBoxTitle.Text;
            movie.Category = TextBoxCategory.Text;
            movie.Cost = TextBoxCost.Text;
            movie.Picture = PictureBoxMovieSelected.Image;

            this.previousForm.Show();
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void calculate()
        {
            double cost = Convert.ToDouble(Convert.ToString(TextBoxCost.Text).Replace("$", String.Empty));
            double dvdCost = 0;
            if (CheckBoxDVD.Checked)
            {
                dvdCost += 10;
            }
            else
            {
                dvdCost = 0;
            }
            double subTotal = cost + dvdCost;
            double salesTax = subTotal * 0.13;
            total = subTotal + salesTax;
            TextBoxSubTotal.Text = subTotal.ToString("C2");
            TextBoxSalesTax.Text = salesTax.ToString("C2");
            TextBoxTotal.Text = total.ToString("C2");
        }

        private void ButtonStream_Click(object sender, EventArgs e)
        {
            
                StreamForm streamForm = new StreamForm();
                streamForm.Show();
                this.Close();
           
            Movie movie = Program.movie;
            movie.Title = TextBoxTitle.Text;
            movie.Cost = TextBoxTotal.Text;
        }

        public void Order_FormClosing(object sender, FormClosingEventArgs e)
        {

                DialogResult result = MessageBox.Show("Are You Sure?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            
        }


        private void CheckBoxDVD_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBoxDVD.Checked)
            {

                calculate();
            }
            else
            {

                calculate();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
    }
}
