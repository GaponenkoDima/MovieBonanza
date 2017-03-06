using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// SelectionForm.cs
/// Author: Dmytro Gaponenko
/// Student ID: 200335210
/// Date: March 05, 2017
/// </summary>
namespace MovieBonanza
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            PopulateMovies();
            ListCurrentMovies.SelectedIndex = 0;
        }
        /// <summary>
        /// Method to Populate Movies
        /// </summary>
        private void PopulateMovies()
        {
            ArrayList movieData = new ArrayList();
            movieData.Add(new Movie { Title = "Season of the Witch", Category = "Sci-Fi", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.Season_of_the_Witch });
            movieData.Add(new Movie { Title = "The Green Hornet", Category = "Action", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.The_Green_Hornet });
            movieData.Add(new Movie { Title = "The Dilemma", Category = "Comedy", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.TheDilemma });
            movieData.Add(new Movie { Title = "Death Race 2", Category = "Action", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.DeathRace2 });
            movieData.Add(new Movie { Title = "Company Men", Category = "Drama", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.MV5BMTQxMTgyNDc5M15BMl5BanBnXkFtZTcwMzk4OTM5Mw____V1_UY1200_CR91_0_630_1200_AL_ });
            movieData.Add(new Movie { Title = "No Strings Attached", Category = "Comedy", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.NoStringsAttached });
            movieData.Add(new Movie { Title = "The Way Back", Category = "Drama", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.TheWayBack });
            movieData.Add(new Movie { Title = "The Mechanic", Category = "Action", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.TheMechanic });
            movieData.Add(new Movie { Title = "The Rite", Category = "Horror", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.TheRite });
            movieData.Add(new Movie { Title = "Sanctum", Category = "Action", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.Sanctum });
            movieData.Add(new Movie { Title = "The Other Woman", Category = "Action", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.TheOtherWoman });
            movieData.Add(new Movie { Title = "The Roommate", Category = "Thriller", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.TheRoommate });
            movieData.Add(new Movie { Title = "Waiting for Forever", Category = "Drama", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.WaitingForForever });
            movieData.Add(new Movie { Title = "Cedar Rapids", Category = "Comedy", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.CedarRapids });
            movieData.Add(new Movie { Title = "Gnomeo and Juliet", Category = "Family", Cost = "0.99", Picture = MovieBonanza.Properties.Resources.Gnomeo });
            movieData.Add(new Movie { Title = "Just Go With It", Category = "Comedy", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.JustGoWithIt });
            movieData.Add(new Movie { Title = "The Eagle", Category = "Action", Cost = "1.99", Picture = MovieBonanza.Properties.Resources.JustGoWithIt });
            movieData.Add(new Movie { Title = "I am Number Four", Category = "Sci-Fi", Cost = "2.99", Picture = MovieBonanza.Properties.Resources.NumberFour });
            movieData.Add(new Movie { Title = "Footloose", Category = "New Releases", Cost = "4.99", Picture = MovieBonanza.Properties.Resources.Footloose });
            movieData.Add(new Movie { Title = "Real Steel", Category = "New Releases", Cost = "4.99", Picture = MovieBonanza.Properties.Resources.RealSteel });

            this.ListCurrentMovies.DisplayMember = "Title";
            this.ListCurrentMovies.DataSource = movieData;
        }
        /// <summary>
        /// Method to fill the text field with choosen selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCurrentMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ListCurrentMovies.ValueMember = "Title";
            TextBoxTitle.Text = ListCurrentMovies.SelectedValue.ToString();

            this.ListCurrentMovies.ValueMember = "Category";
            TextBoxCategory.Text = ListCurrentMovies.SelectedValue.ToString();

            this.ListCurrentMovies.ValueMember = "Cost";
            TextBoxCost.Text = ListCurrentMovies.SelectedValue.ToString();
            double cost = Convert.ToDouble(Convert.ToString(TextBoxCost.Text));
            TextBoxCost.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", cost);

            this.ListCurrentMovies.ValueMember = "Picture";
            PictureBoxMovieSelected.Image = (Image)ListCurrentMovies.SelectedValue;

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Movie movie = Program.movie;
            movie.Title = TextBoxTitle.Text;
            movie.Category = TextBoxCategory.Text;
            movie.Cost = TextBoxCost.Text;
            movie.Picture = PictureBoxMovieSelected.Image;


            this.Hide();
            OrderForm1 orderForm = new OrderForm1();
            orderForm.previousForm = this;
            orderForm.Show();
        }
    }
}
