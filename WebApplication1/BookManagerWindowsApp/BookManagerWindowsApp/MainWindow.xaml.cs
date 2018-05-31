using PaulCCA.BookLibrary;
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

namespace BookManagerWindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book
            {
                Author = AuthorTextBox.Text,
                Title = TitleTextBox.Text,
                Genre = GenreTextBox.Text
            };

            OutputTextBox.Text = book.GetFullName();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuthorTextBox.Text = "";
            TitleTextBox.Text = "";
            GenreTextBox.Text = "";
            OutputTextBox.Text = "";
        }
    }
}
