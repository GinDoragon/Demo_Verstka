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
using System.Windows.Threading;

namespace Demo_Verstka
{
    /// <summary>
    /// Логика взаимодействия для AgentsPage.xaml
    /// </summary>
    public partial class AgentsPage : Page
    {
        public AgentsPage()
        {
            InitializeComponent();
            ListAgents.ItemsSource = DB.agentsEntities.Agent.ToList();
            cbFilter.Items.Add("По типу");
            cbSort.Items.Add("от А до Я");
        }
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ListAgents.ItemsSource = DB.agentsEntities.Agent.Where(x => x.Title.StartsWith(txtSearch.Text)).ToList();
        }
    }
}
