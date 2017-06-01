using MySql.Data.MySqlClient;
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

namespace Cursos
{
    /// <summary>
    /// Interaction logic for Cursos.xaml
    /// </summary>
    public partial class Cursos : Window
    {
        public Cursos()
        {
            InitializeComponent();
            
        }

        private void nomes_lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=Cursos;Uid=root;pwd="),
                CommandText = "SELECT FROM Curso descricao)"
            };
            cmd.Connection.Open();
            MySqlDataReader r;
            r = cmd.ExecuteReader();
            cmd.Connection.Close();
        }
    }
}
