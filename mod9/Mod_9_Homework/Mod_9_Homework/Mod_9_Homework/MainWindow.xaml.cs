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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();
        int counter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student s1 = new Student();
            s1.FirstName = txtFirstName.Text;
            s1.LastName = txtLastName.Text;
            s1.City = txtCity.Text;
            studentList.Add(s1);

            counter = studentList.Count();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)
            {
                //counter++;
                btnPrevious.IsEnabled = false; //another way
            }
            txtFirstName.Text = studentList[counter - 1].FirstName;
            txtLastName.Text = studentList[counter - 1].LastName;
            txtCity.Text = studentList[counter - 1].City;
            counter--;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            btnPrevious.IsEnabled = true;
            if (counter == studentList.Count()-1)
            {
                //counter--;
                txtFirstName.Clear(); //at the last item in list collection, when clicking next, all fields are cleared.
                txtLastName.Clear();
                txtCity.Clear();
            }
            else
            {
                txtFirstName.Text = studentList[counter + 1].FirstName; //at other item than the last, clicking next read the next element and counter plus 1
                txtLastName.Text = studentList[counter + 1].LastName;
                txtCity.Text = studentList[counter + 1].City;
                counter++;
            }
        }
    }
}
