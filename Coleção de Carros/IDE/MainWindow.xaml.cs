using Microsoft.VisualBasic;
using MySqlConnector;
using System.Collections.ObjectModel;
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
using MySqlConnector;

namespace IDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Carros> ListaCarros = new ObservableCollection<Carros>();

        public MainWindow()
        {
            InitializeComponent();
            dataGridCarros.ItemsSource = ListaCarros;

            Models service = new Models();
            service.AdicionarValoresListaCarros(ListaCarros);
        }

        private void Button_OpenWindowCadastro(object sender, RoutedEventArgs e)
        {
            Cadastro cadastroWindow = new Cadastro(ListaCarros);
            cadastroWindow.Show();
        }

       private void Button_EditarCarro(object sender, RoutedEventArgs e)
        {
           var botao = sender as Button;
           var carroSelecionado = botao.DataContext as Carros;

           Editar editarWindow = new Editar(carroSelecionado);
           editarWindow.Show();

        }



    }
}