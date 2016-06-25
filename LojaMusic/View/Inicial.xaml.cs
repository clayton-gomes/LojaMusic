using LojaMusic.View;
using System;
using System.Collections.Generic;
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

namespace LojaMusic
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

        private void btnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cadastrarcliente = new CadastrarCliente();
            cadastrarcliente.ShowDialog();
        }

        private void btnCadastrarCategoria_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCategoria cadastarCategoria = new CadastrarCategoria();
            cadastarCategoria.ShowDialog();
        }

        private void btnCadastrarInstrumento_Click(object sender, RoutedEventArgs e)
        {
            CadastrarInstrumento cadastrarInstrumento = new CadastrarInstrumento();
            cadastrarInstrumento.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cadastrarcliente = new CadastrarCliente();
            cadastrarcliente.ShowDialog();
        }

        private void CadastroInstrumento_Click(object sender, RoutedEventArgs e)
        {
            CadastrarInstrumento cadastrarInstrumento = new CadastrarInstrumento();
            cadastrarInstrumento.ShowDialog();
        }

        private void CadastroCategoria_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCategoria cadastarCategoria = new CadastrarCategoria();
            cadastarCategoria.ShowDialog();
        }

       

        
    }
}
