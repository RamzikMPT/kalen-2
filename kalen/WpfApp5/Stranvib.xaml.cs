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
    
    public partial class Stranvib : Page
    {
        List<SelectedElement>  SelectedObjects = new List<SelectedElement>();
        List<VIBRANELEMENTS> selecteditems = new List<VIBRANELEMENTS>();
        

        public string DayMonthYear;
        public Stranvib()
        {
            InitializeComponent();

            List<obektkalend> languages = new List<obektkalend> {
                new obektkalend("vishya", "/vishnya.png"),
                new obektkalend("ponchik", "/pon.png"),
                new obektkalend("kartoha", "/kartoshka.png")
};

            List<SelectedElement> SelectedObjects = new List<SelectedElement>();

            foreach (obektkalend lang in languages)
            {
                SelectedElement userGame = new SelectedElement(lang);
                SelectedObjects.Add(userGame);
            }

            SelectedList.ItemsSource = SelectedObjects;




        }

        
        

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).FirstFrame.Content = new Page1();
        }

       
    }
}
