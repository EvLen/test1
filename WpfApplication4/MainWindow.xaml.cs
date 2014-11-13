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
using System.ComponentModel;

namespace WpfApplication4
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }
        
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _animal.Name = "Lassie (Dog)";
            DataContext = _animal;

            _button.Click += delegate(object s, RoutedEventArgs e2)
            {
                _animal.Name = "Beaker (cat)";
            };
        }

     

        Animal _animal = new Animal();

        private void _button_Click(object sender, RoutedEventArgs e)
        {

        }    
  
    }


    public class Animal : INotifyPropertyChanged
    {
        public string Name 
        {
            get { return _name; }
            
            set
            {
            
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        
        }

        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
