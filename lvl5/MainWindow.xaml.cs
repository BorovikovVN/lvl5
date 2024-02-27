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

namespace lvl5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listv.Items.Add(new ListItem());
            listv.Items.Add(new ListItem());
            listv.Items.Add(new ListItem());
            listv.Items.Add(new ListItem());
            listv.Items.Add(new ListItem());
            ComboBox1.Items.Add("Элемент1");
            ComboBox1.Items.Add("Элемент2");
            ComboBox1.Items.Add("Элемент3");

            this.Title = "Уровень 5";
        }
    }
}