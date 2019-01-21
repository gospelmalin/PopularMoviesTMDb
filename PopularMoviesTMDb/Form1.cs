using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PopularMoviesTMDb
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

       

        private void showTopRatedBtn_Click(object sender, EventArgs e)
        {
            if(apiKeyExist()) { 
           
                String apiKey = apiKeyTextBox.Text;
                resultBoxLabel.Text = "Top rated movies";
                String result = "";
                resultTextBox.ResetText();
                List<Movie> topRatedMovies = new List<Movie>();
                JsonHandler j = new JsonHandler();
                //topRatedMovies = j.createTopRatedMoviesListFromJsonString(); // To be used when apiKey is read from settings/properties/file
                topRatedMovies = j.createTopRatedMoviesListFromJsonString(apiKey);
                foreach (Movie topRatedMovie in topRatedMovies)
                {
                    Console.WriteLine(topRatedMovie.ToString());
                    //  result = result + "\n" + resultingMovie.ToString() ;
                    result = topRatedMovie.ToString() + "\n";
                    resultTextBox.AppendText(result);
                }
            }
        }

        private void showPopularBtn_Click(object sender, EventArgs e)
        {
            if (apiKeyExist())
            {
                String apiKey = apiKeyTextBox.Text;
                resultBoxLabel.Text = "Popular movies";
                String result = "";
                resultTextBox.ResetText();
                List<Movie> popularMovies = new List<Movie>();
                JsonHandler j = new JsonHandler();
                //  popularMovies = j.createPopularMoviesListFromJsonString(); // To be used when apiKey is read from settings/properties/file
                popularMovies = j.createPopularMoviesListFromJsonString(apiKey);
                foreach (Movie popularMovie in popularMovies)
                {
                    Console.WriteLine(popularMovie.ToString());
                    //  result = result + "\n" + resultingMovie.ToString() ;
                    result = popularMovie.ToString() + "\n";
                    resultTextBox.AppendText(result);
                }
              
            }
        }

        // Check that an API Key has been entered
        private Boolean apiKeyExist()
        {
            if (apiKeyTextBox.Text.Equals(null) || apiKeyTextBox.Text.Equals(""))
            {
                apiKeyLabel.ForeColor = Color.Red;
                return false;
            }
            else
            {
                apiKeyLabel.ForeColor = SystemColors.ControlText;
                return true;
            }
        }

        // Not used
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        // Not used
        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        // Not used
        private void tableMovies_Click(object sender, EventArgs e)
        {

        }

        // Not used
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
