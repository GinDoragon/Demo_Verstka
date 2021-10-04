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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class PageManager : Page
    {
        Frame Mframe;
        public PageManager(Frame frame)
        {
            InitializeComponent();
            Mframe = frame;
        }
        /// <summary>
        /// Событие нажатия на кнопку "Агенты" <br></br>
        /// Переносит на страницу AgentsPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agents_Click(object sender, RoutedEventArgs e)
        {
            Mframe.Navigate(new AgentsPage());
        }
    }
}
