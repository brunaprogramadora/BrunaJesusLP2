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
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void cadastrar_btn_Click(object sender, RoutedEventArgs e)
        {
            string nome = nome_txt.Text;
            string descricao = descricao_txt.Text;
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;pwd="),
                CommandText = "INSERT INTO CURSO (nome, descricao) VALUES (@nome, @descricao)"
            };

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@descricao", descricao);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            descricao_txt.Clear();
            nome_txt.Clear();
        }
    }
}
