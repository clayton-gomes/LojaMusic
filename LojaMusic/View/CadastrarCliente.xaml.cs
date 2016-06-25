using LojaMusic.DAO;
using LojaMusic.Model;
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
using System.Windows.Shapes;

namespace LojaMusic.View
{
    /// <summary>
    /// Interaction logic for CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void Gravar_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.ClienteNome = txtNome.Text;
            c.ClienteIdade = txtIdade.Text;
            c.ClienteTelefone = txtTelefone.Text;
            c.ClienteCpf = txtCPF.Text;
            c.ClienteCep = txtCEP.Text;

            if (ClienteDAO.AdicionarCliente(c))
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar!");
            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            LimparFormulario();
        }

        public void LimparFormulario()
        {
            
            txtCPF.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
            txtCEP.Clear();
            btnGravar.IsEnabled = true;
        }

       
    }
}
