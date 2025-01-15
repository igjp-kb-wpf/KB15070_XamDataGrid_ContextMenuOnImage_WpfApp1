using Infragistics.Windows.DataPresenter;
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

namespace KB15070_WpfApp1
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

        private void contextMenu_Opening(object sender, Infragistics.Controls.Menus.OpeningEventArgs e)
        {
            var clickedImage = e.GetClickedElements<Image>().Count > 0 ? e.GetClickedElements<Image>().First() : null;
            var clickedCellValuePresenter = e.GetClickedElements<CellValuePresenter>().FirstOrDefault(cvp => cvp.Field.Name == "Menu");
            if (clickedImage == null
                || clickedCellValuePresenter == null)
            {
                e.Cancel = true;
            }
        }
    }
}