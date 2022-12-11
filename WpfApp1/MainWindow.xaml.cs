using Microsoft.SqlServer.Server;
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

namespace WpfApp1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp1.DataSet dataSet = ((WpfApp1.DataSet)(this.FindResource("dataSet")));
            // Load data into the table Table. You can modify this code as needed.
            WpfApp1.DataSetTableAdapters.TableTableAdapter dataSetTableTableAdapter = new WpfApp1.DataSetTableAdapters.TableTableAdapter();
            dataSetTableTableAdapter.Fill(dataSet.Table);
            System.Windows.Data.CollectionViewSource tableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tableViewSource")));
            //
            dataSet.AcceptChanges();
            dataSet.Table.AcceptChanges();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //WpfApp1.DataSet dataSet = ((WpfApp1.DataSet)(this.FindResource("dataSet")));
            //dataSet.Table.AcceptChanges();
            //dataSet.AcceptChanges();
            ////dataSet.Table.AddTableRow(firstNameTextBox.Text, lastNameTextBox.Text, yearOfInrollTextBox.Text);
            //DataRow dataRow = dataSet.tableTable.NewRow();
            //dataRow[1] = firstNameTextBox.Text;
            //dataRow[2] = lastNameTextBox.Text;
            //dataRow[3] = yearOfInrollTextBox.Text;
            //dataSet.tableTable.Rows.Add(dataRow);
        }

        private void buttonAdd2_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.DataSet dataSet = ((WpfApp1.DataSet)(this.FindResource("dataSet")));
            dataSet.Table.AcceptChanges();
            dataSet.AcceptChanges();
            dataSet.tableTable.AddTableRow(textBoxFName.Text, textBoxLName.Text, textBoxYearOfInroll.Text);
            //dataSet.WriteXml(textBoxFName.Text, textBoxLName.Text, textBoxYearOfInroll.Text));
        }
    }
}
