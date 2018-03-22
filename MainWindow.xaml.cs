/*
 * Aidan McClung
 * March 21, 2018
 * u2LoopReveiw
 * averages a series of numbers input by the user.
*/
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

namespace u2LoopReview
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

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            string textEntered = txtInput.Text;

            MessageBox.Show(textEntered);
            int PositionOfSlashR = textEntered.IndexOf('\r');
            //MessageBox.Show(textEntered.IndexOf('\r').ToString());
            string tempNumber = textEntered.Substring(0, PositionOfSlashR);
            //MessageBox.Show(tempNumber);
            double total = 0;
            int counter = 0;
            int numberEntered = 0;
            int.TryParse(tempNumber, out numberEntered);
            while(numberEntered != -1)
            {
                total = total + numberEntered;
                counter++;
                int previousPositionOfSlashR = PositionOfSlashR;
                PositionOfSlashR = textEntered.IndexOf('\r', PositionOfSlashR + 1);
                tempNumber = textEntered.Substring(previousPositionOfSlashR+2, 
                    PositionOfSlashR-previousPositionOfSlashR-2);
                int.TryParse(tempNumber, out numberEntered);
                MessageBox.Show("in loop total is" + total.ToString());

            }
            MessageBox.Show("out of loop total is" + total.ToString());
            double average = total / counter;
            MessageBox.Show("average is " + average);
            lblOutput.Content = "Average is " + average;
        }
    }
}
