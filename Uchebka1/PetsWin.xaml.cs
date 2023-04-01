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
    /// Логика взаимодействия для PetsWin.xaml
    /// </summary>
    public partial class PetsWin : Window
    {
        PetTableAdapter petss = new PetTableAdapter();
        foodTableAdapter foodd = new foodTableAdapter();
        public PetsWin()
        {
            InitializeComponent();
            petsGridd.ItemsSource = petss.GetData();
            FoodCbx.ItemsSource = foodd.GetData();
            FoodCbx.DisplayMemberPath = "name";
        }

        private void Sozd_Click(object sender, RoutedEventArgs e)
        {
            petss.InsertQuery(pisalka.Text, pisalkaType.Text, (int)(FoodCbx.SelectedValue as DataRowView).Row[0]);
            petsGridd.ItemsSource = petss.GetData();
        }

        private void petsGridd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (petsGridd.SelectedItem != null)
            {
                var sel =petsGridd.SelectedItem as DataRowView;
            }
        }

        private void Udal_Click(object sender, RoutedEventArgs e)
        {
            if (petsGridd.SelectedItem != null)
            {
                var sell = ((petsGridd.SelectedItem) as DataRowView).Row[0];
                petss.DeleteQuery((int)sell);
                petsGridd.ItemsSource = petss.GetData();
            }
        }
    }
}
