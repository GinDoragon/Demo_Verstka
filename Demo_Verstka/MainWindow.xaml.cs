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

namespace Demo_Verstka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageManager(MainFrame));
            this.MinHeight = 500;
            this.MinWidth = 800;
            //this.MaxHeight = 800;
            //this.MaxWidth = 1100;
        }
        /// <summary>
        /// Событие нажатия кнопки "Назад" <br></br>
        /// Возвращает на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoBack) MainFrame.GoBack();
        }
    }
}
