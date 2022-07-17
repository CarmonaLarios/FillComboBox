using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PreencherCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conexao = @"Data Source=ARDANUY\PREF;Initial Catalog=CadCli;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            string comando = "SELECT NOME_USU FROM USUARIO";
            string users;

            SqlConnection cn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(comando,cn);


            try
            {
                cn.Open();

            }

            catch (Exception E)

            {
                MessageBox.Show(E.Message);

            }

            SqlDataReader rd = null;

            rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                users = rd["NOME_USU"].ToString();

                cmbUser.Items.Add(users);

            }


        }
    }
}
