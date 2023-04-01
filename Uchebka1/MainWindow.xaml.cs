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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Uchebka1.PetsDataSetTableAdapters;

namespace Uchebka1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PetTableAdapter petsss = new PetTableAdapter();
        foodTableAdapter foodd = new foodTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            petsGrid.ItemsSource = petsss.GetData();
            foodGrid.ItemsSource=foodd.GetData();
        }

        private void petsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel = petsGrid.SelectedItem as DataRowView;
            MessageBox.Show(sel.Row[1] + " " + sel.Row[2] + " " + sel.Row[3]);
        }

        private void foodButt_Click(object sender, RoutedEventArgs e)
        {
            foodWin win = new foodWin();
            win.Show();
        }

        private void petButt_Click(object sender, RoutedEventArgs e)
        {
            PetsWin win2 = new PetsWin();
            win2.Show();
        }

        private void foodGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sel = foodGrid.SelectedItem as DataRowView;
            MessageBox.Show((string)sel.Row[1]);
        }
    }
}
