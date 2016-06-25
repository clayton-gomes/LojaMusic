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
    /// Interaction logic for CadastrarCategoria.xaml
    /// </summary>
    public partial class CadastrarCategoria : Window
    {
        public CadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btnCtgGravar_Click(object sender, RoutedEventArgs e)
        {
            Categoria Ctg = new Categoria();
            Ctg.CategoriaNome = txtCtgNome.Text;

            if (CategoriaDAO.AdicionarCategoria(Ctg))
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar categoria!");
            }
        }
    }
}
