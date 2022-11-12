using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.CapaPresentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Botones

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDPersonales_Click(object sender, EventArgs e)
        {
            pnlDatosPersonales.Visible = true;
            //pnlUltMov.Visible = false;
            //pnlDepositos.Visible = false;
            //pnlTransfer.Visible = false;
        }

        private void btnUltMov_Click(object sender, EventArgs e)
        {
            pnlDatosPersonales.Visible = false;
            //pnlUltMov.Visible = true;
            //pnlDepositos.Visible = false;
            //pnlTransfer.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        #endregion


    }
}
