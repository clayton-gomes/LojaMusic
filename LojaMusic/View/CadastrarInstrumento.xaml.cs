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
    /// Interaction logic for CadastrarInstrumento.xaml
    /// </summary>
    public partial class CadastrarInstrumento : Window
    {
        public CadastrarInstrumento()
        {
            InitializeComponent();
            cboCategorias.ItemsSource = CategoriaDAO.RetornarLista();
            cboCategorias.DisplayMemberPath = "CategoriaNome";
            cboCategorias.SelectedValuePath = "CategoriaId";

            //Convert.ToInt32(cboCategorias.SelectedValue);
        }

        private void btnGravarInstrumento_Click(object sender, RoutedEventArgs e)
        {
            int aux = Convert.ToInt32(cboCategorias.SelectedValue);
            Instrumento i = new Instrumento();
            i.InstrumentoNome = txtInstNome.Text;
            i.InstrumentoPreco = float.Parse(txtInstPreco.Text);
            i.InstrumentoCategoria = CategoriaDAO.RetornarCategoriaId(aux);

            if (InstrumentoDAO.AdicionarInstrumento(i))
            {
                MessageBox.Show("Instrumento cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar instrumento!!");
            }

        }
    }
}
