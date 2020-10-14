using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        GameForm gameWindow;
        public MainForm()
        {
            InitializeComponent();
        }

        private void TechnologyCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "COMPUTER", "STORAGE", "INTERNET", "TABLET", "WIFI", "PROGRAMMING", "SOFTWARE" };

            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void AnimalCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "SKUNK", "TIGER", "GIRAFFE", "MONKEY", "TURTLE", "CAT", "DOG", "EAGLE", "BEAR", "HORSE", "DUCK", "LAMB", "PIG", "CHICKEN" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void FoodCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "APPLE", "BANANA", "GRAPE","POTATO", "STEAK", "HAMBURGER", "CHEESE", "PIZZA" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void SportsCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "FOOTBALL", "SOCCER", "HOCKEY", "BASKETBALL", "JETS", "GIANTS", "PATRIOTS", "GOAL" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void PoliticsCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "DEMOCRAT", "REPUBLICAN", "INDEPENDENT", "LIBERTARIAN", "OBAMA", "CLINTON", "BUSH", "REAGAN" };
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }

        private void CountriesCategoryTile_Click(object sender, EventArgs e)
        {
            string[] words = { "CANADA", "UGANDA", "IRAQ", "INDIA", "CHINA", "JAPAN", "RUSSIA"};
            gameWindow = new GameForm(words);
            gameWindow.ShowDialog();
        }
    }
}
