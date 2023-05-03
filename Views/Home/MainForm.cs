using LoginActiveDirectory02.Controllers;
using System;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Forms;

namespace LoginActiveDirectory02.Views.Home
{
    public partial class MainForm : Form
    {
        private string pathLDAP = "LDAP://bosque1.com/DC=bosque1,DC=com";

        public static string NombreCompleto, NTusername, version, co, error;
        UsersController userC = new UsersController();

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (AutenticarUsuario(TxbUser.Text.Trim().ToString(), TxbPassword.Text.ToString()))
            {
                LblMensajes.Text = "Acceso autorizado.";
                LblMensajes.BackColor = Color.Green;
                LblMensajes.ForeColor = Color.White;
            }
            else
            {
                LblMensajes.Text = "Acceso denegado." + error;
                LblMensajes.BackColor = Color.Red;
                LblMensajes.ForeColor = Color.Black;
            }
        }

        private bool AutenticarUsuario(string userName, string password)
        {

            if (userName == string.Empty || password == string.Empty)
            {
                return false;
            }

            bool esAutenticado = false;
            try
            {
                DirectoryEntry directoryEntry = new DirectoryEntry(userC.GetCurrentDomainPath(), userName, password);
                //DirectoryEntry directoryEntry = new DirectoryEntry(pathLDAP, userName, password);                
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
                }
                else
                {
                    MessageBox.Show("Información proporcionada ES CORRECTA \nPero no tienes permisos suficientes.");
                }
            }
            catch (Exception ex)
            {
                esAutenticado = false;
                error = ex.Message;

                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Este equipo no pertenece a ningún dominio de Active Directory. " + ex);
            }

            Console.WriteLine($"Res::::: NombreCompleto = {NombreCompleto}, NTusername = {NTusername}, co = {co}");

            Console.WriteLine($"Res::::: NombreCompleto = {NombreCompleto}, NTusername = {NTusername}, co = {co}");
            return esAutenticado;
        }

    }


}
