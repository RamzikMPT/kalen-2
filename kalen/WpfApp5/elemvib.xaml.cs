using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp5
{

    public partial class SelectedElement : UserControl
    {
        public obektkalend SelectedClass { get; private set; }
        public SelectedElement(obektkalend selectedclass)
        {
            this.SelectedClass = selectedclass;
            InitializeComponent();

            Textblock.Text = selectedclass.n.ToString();
            image.Source = new BitmapImage(new Uri(selectedclass.i, UriKind.RelativeOrAbsolute));
            Checkbox.IsChecked = selectedclass.v;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SelectedClass.v = (bool)Checkbox.IsChecked;
        }
    }
}
