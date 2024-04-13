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
using System.Windows.Shapes;

namespace cw_40125689
{
    /* Award.xaml.cs
    * Second window of the application.
    * Displays the values and the award of the Student instance, only if the award can be determined for the student.
    *
    * Written by Igors Ahmetovs 19/10/2015
    *
    */
    public partial class Award : Window
    {
        public Award(string m, string s, string f, string c, string l, string a) // the default constructor with 6 arguments 
        {
            InitializeComponent();

            // filling the contents of the labels with the data passed to the constructor

            lblMatricNumber.Content = m;
            lblSecondName.Content = s;
            lblFirstName.Content = f;
            lblCourse.Content = c;
            lblLevel.Content = l;
            lblAward.Content = a;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e) // close button closes the current window
        {
            this.Close();
        }
    }
}
