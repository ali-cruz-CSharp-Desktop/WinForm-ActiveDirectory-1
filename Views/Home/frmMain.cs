using LoginActiveDirectory02.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginActiveDirectory02
{
    public partial class Form1 : Form
    {
        public static string NombreCompleto, NTusername, version, co, error;
        UsersController userC = new UsersController();


        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (AutenticarUsuario(textEdit1.Text.ToString(), textEdit2.Text.ToString()))
            {
                lblAcceso.Text = "Acceso autorizado.";
                lblAcceso.BackColor = Color.Green;
                lblAcceso.ForeColor = Color.White;
            } else
            {
                lblAcceso.Text = "Acceso denegado." + error;
                lblAcceso.BackColor = Color.Red;
                lblAcceso.ForeColor = Color.Black;
            }
        }

        
        private bool AutenticarUsuario(string userName, string password)
        {
            bool esAutenticado = false;
            try
            {
                DirectoryEntry directoryEntry = new DirectoryEntry(userC.GetCurrentDomainPath(), userName, password);
                DirectorySearcher directorySearch = new DirectorySearcher(directoryEntry);
                directorySearch.Filter = "sAMAccountName=" + userName + "";
                SearchResult searchResult = null;

                searchResult = directorySearch.FindOne();

                NombreCompleto = searchResult.GetDirectoryEntry().Properties["DisplayName"].Value.ToString();
                NTusername = searchResult.GetDirectoryEntry().Properties["sAMAccountName"].Value.ToString();
                co = searchResult.GetDirectoryEntry().Properties["department"].Value.ToString();

                if (userC.GetNTuser(NTusername))
                {
                    esAutenticado = true;
                } else
                {
                    MessageBox.Show("Información proporcionada ES CORRECTA \nPero no tienes permisos suficientes.");
                }
            } catch (Exception ex)
            {
                esAutenticado = false;
                error = ex.Message;

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Console.WriteLine($"Res::::: NombreCompleto = {NombreCompleto}, NTusername = {NTusername}, co = {co}");
            return esAutenticado;
        }
    }
}
