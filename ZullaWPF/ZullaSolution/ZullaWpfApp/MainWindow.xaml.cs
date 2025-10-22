using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZullaWpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string title = txtTitle.Text;
            string style = txtStyle.Text;
            string instructor = txtInstructor.Text;
            string schedule = txtSchedule.Text;

            if (id == "" || title == "" || style == "" || instructor == "" || schedule == "")
            {
                MessageBox.Show("Please fill in all fields before saving.",
                                "Missing Information",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show($"Dance Class Saved!\n\n" +
                                $"ID: {id}\n" +
                                $"Title: {title}\n" +
                                $"Style: {style}\n" +
                                $"Instructor: {instructor}\n" +
                                $"Schedule: {schedule}",
                                "Saved Successfully",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }
    }
}
