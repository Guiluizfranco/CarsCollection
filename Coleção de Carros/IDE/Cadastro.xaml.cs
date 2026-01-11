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
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        ObservableCollection<Carros> listaCarros;
        public Cadastro(ObservableCollection<Carros> ListaCarros)
        {
            InitializeComponent();
            this.listaCarros = ListaCarros;

        }

        
        
        Models conexaoClasses = new Models();
        private void Button_Cadastrar(object sender, RoutedEventArgs e)
        {
            Carros carro = new Carros();

            carro.id = int.Parse(TextId.Text); 

            carro.nome = TextNome.Text; if(string.IsNullOrEmpty(carro.nome))
            {
                MessageBox.Show("O campo NOME é obrigatório!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            carro.marca = TextMarca.Text; if(string.IsNullOrEmpty(carro.marca))
            {
                MessageBox.Show("O campo MARCA é obrigatório!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            carro.ano = int.Parse(TextAno.Text); if (carro.ano >= 2027 || carro.ano <= 0)
            {
                MessageBox.Show("O campo ANO deve ser um valor válido!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            } 

            carro.preco = float.Parse(TextPreco.Text); if (carro.preco <= 0)
            {
                MessageBox.Show("O campo PREÇO deve ser um valor válido!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            conexaoClasses.Cadastrar(carro.id, carro.nome, carro.marca, carro.ano, carro.preco);
            listaCarros.Add(carro);
        }
    }
}
