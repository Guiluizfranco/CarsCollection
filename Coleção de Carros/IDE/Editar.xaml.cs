using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IDE
{
    /// <summary>
    /// Lógica interna para Editar.xaml
    /// </summary>

    public partial class Editar : Window
    {
        Carros carroSelecionado;
        ObservableCollection<Carros> listaCarros;
        public Editar(Carros carroSelecionado)
        {
            InitializeComponent();
            this.carroSelecionado = carroSelecionado;


            DataContext = carroSelecionado;
        }

        private void Button_SalvarEdicao(object sender, RoutedEventArgs e)
        {
            Models conexaoClasses = new Models();
            string conversãoID = carroSelecionado.id.ToString();
            conexaoClasses.Atualizar(carroSelecionado.nome, carroSelecionado.marca, carroSelecionado.ano, carroSelecionado.preco, conversãoID);
        }
    }
}
