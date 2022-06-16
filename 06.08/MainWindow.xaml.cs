using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
namespace _06._08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int row = 0;
        List<string> words = new();
        string mainword;
        public MainWindow()
        {
            InitializeComponent();
            using (StreamReader rd = new("Ru5.txt"))
            {
                while (!rd.EndOfStream)
                {
                words.Add(rd.ReadLine());
                }
            }
            Random random = new Random();
            mainword = words[random.Next(words.Count - 1)].ToUpper();
            this.Title = mainword;
        }

        private void row_chenged0(object sender, RoutedEventArgs e) {
            row = 1;
            for (int i = 0; i < 5; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i]).Text) == i)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
        }
        private void row_chenged1(object sender, RoutedEventArgs e)
        {
            row = 2;
            for (int i = 5; i < 10; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i-5]).Text) == i-5)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
        }
        private void row_chenged2(object sender, RoutedEventArgs e)
        {
            row = 3;
            for (int i = 10; i < 15; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i -10]).Text) == i-10)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
        }
        private void row_chenged3(object sender, RoutedEventArgs e)
        {
            row = 4;
            for (int i = 15; i < 20; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i-15]).Text) == i-15)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
        }
        private void row_chenged4(object sender, RoutedEventArgs e)
        {
            row = 5;
            for (int i = 20; i < 25; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i-20]).Text) == i-20)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
        }

        void reset_game()
        {
            for (int i = 0; i < wordsgrid.Children.Count; i++)
            {
                ((TextBox)wordsgrid.Children[i]).Text = string.Empty;
                ((TextBox)wordsgrid.Children[i]).Background = default;
            }
            Random random = new Random();
            mainword = words[random.Next(words.Count - 1)].ToUpper();
            this.Title = mainword;
        }
        private void row_chenged5(object sender, RoutedEventArgs e)
        {
            row = 0;
            for (int i = 25; i < 30; i++)
            {
                if (mainword.Contains(((TextBox)wordsgrid.Children[i]).Text))
                {
                    if (mainword.IndexOf(((TextBox)wordsgrid.Children[i-25]).Text) == i-25)
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Green;
                    else
                        ((TextBox)wordsgrid.Children[i]).Background = Brushes.Yellow;
                }
                else
                    ((TextBox)wordsgrid.Children[i]).Background = Brushes.Gray;
            }
            reset_game();
        }
        private void test(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < wordsgrid.Children.Count; i++)
            {
                ((TextBox)wordsgrid.Children[i]).Text = wordsgrid.Children.Count.ToString();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (row == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }

           else if (row == 1)
            {
                for (int i = 5; i < 10; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }
            else if(row == 2)
            {
                for (int i = 10; i <15; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }
            else if (row == 3)
            {
                for (int i = 15; i < 20; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }
            else if (row == 4)
            {
                for (int i =20; i < 25; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }
            else if (row == 5)
            {
                for (int i = 25; i <30; i++)
                {
                    if (((TextBox)wordsgrid.Children[i]).Text == string.Empty)
                    {
                        ((TextBox)wordsgrid.Children[i]).Text = ((Button)sender).Content.ToString();
                        break;
                    }
                }
            }
        }
    }
}   