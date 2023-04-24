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

namespace WpfApp5
{
   
    public partial class Page1 : Page
    {
        
        public static DateTime gmd;
       
        public Page1()
        {
            InitializeComponent();
            gmd = DateTime.Now;
            day.Text = gmd.ToString("dd MMMM yyyy");
            updatedate(DateTime.DaysInMonth(gmd.Year, gmd.Month));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gmd = gmd.AddMonths(1);
            day.Text = gmd.ToString("dd MMMM yyyy");

            updatedate(DateTime.DaysInMonth(gmd.Year, gmd.Month));

            
        }
        private void datepicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datepicker.SelectedDate != null)
            {
                gmd = datepicker.SelectedDate.Value;
                day.Text = gmd.ToString("dd MMMM yyyy");

                updatedate(DateTime.DaysInMonth(gmd.Year, gmd.Month));
            }
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gmd = gmd.AddMonths(-1);
            day.Text = gmd.ToString("dd MMMM yyyy");

            updatedate(DateTime.DaysInMonth(gmd.Year, gmd.Month));


        }

        
        private void updatedate(int gmd1)
        {
            wrap.Children.Clear();
            List<hhh> kalendars = new List<hhh>();
            for (int i = 1; i <= gmd1; i++)
            {
                hhh a = new hhh();
                a.dayButton.Content = i.ToString();
                wrap.Children.Add(a);
            }
        }
    }
}
