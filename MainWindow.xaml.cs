using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace лабораторка6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                closeButton.IsEnabled = true;
            }
            else
            {
                closeButton.IsEnabled = false;
            }
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void styleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)styleComboBox.SelectedItem;

            switch (selectedItem.Content.ToString())
            {
                case "Стиль 1":
                    textBox1.Style = (Style)FindResource("Style1");
                    textBox2.Style = (Style)FindResource("Style1");
                    break;
                case "Стиль 2":
                    textBox1.Style = (Style)FindResource("Style2");
                    textBox2.Style = (Style)FindResource("Style2");
                    break;
                case "Стиль 3":
                    textBox1.Style = (Style)FindResource("Style3");
                    textBox2.Style = (Style)FindResource("Style3");
                    break;
            }
        }
    }
}