using System;
using System.Collections.Generic;
using System.Data;
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
using Uchebka1.PetsDataSetTableAdapters;

namespace Uchebka1
{
    /// <summary>
    /// Логика взаимодействия для foodWin.xaml
    /// </summary>
    public partial class foodWin : Window
    {
        foodTableAdapter food = new foodTableAdapter();
        public foodWin()
        {
            InitializeComponent();
            foodGridd.ItemsSource = food.GetData();
        }

        private void sozd_Click(object sender, RoutedEventArgs e)
        {
            food.InsertQuery(pisalka.Text);
            foodGridd.ItemsSource = food.GetData();
        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (foodGridd.SelectedItem != null)
            {
                var sell = ((foodGridd.SelectedItem) as DataRowView).Row[0];
                food.DeleteQuery((int)sell);
                foodGridd.ItemsSource = food.GetData();
            }
        }

        private void foodGridd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (foodGridd.SelectedItem != null)
            {
                var sel = foodGridd.SelectedItem as DataRowView;
            }
        }
    }
}
