using HHLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace BotWpf418
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            ResListBox.Items.Clear();
            HHModel m = new HHModel();
            List<Vacancy> v = m.JsonParseStringItems(
                m.RequestGet("http://api.hh.ru/vacancies?text=" + searchBox.Text));

            foreach (Vacancy vacancy in v)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = vacancy.id + " " + vacancy.name;
                item.Tag = vacancy.info;
                ResListBox.Items.Add(item);
            }
        }

        private void buttonView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBoxItem item = (ListBoxItem)ResListBox.SelectedItem;
                //MessageBox.Show(item.Tag.ToString());
                Process.Start(item.Tag.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Укажите желаемую вакансию!\r\n\n" + ex.Message);
            }
        }
    }
}
