using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.CapaLogica;
using System.Runtime.InteropServices;


namespace _3.CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region TxtBoxs

        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "123456")
            {
                txtBoxPass.Text = "";
                txtBoxPass.ForeColor = Color.White;
            }
        }

        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text == "")
            {
                txtBoxPass.Text = "123456";
                txtBoxPass.ForeColor = Color.DimGray;
            }
        }

        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "Username")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.White;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "Username";
                txtBoxUser.ForeColor = Color.DimGray;
            }
        }

        #endregion
        #region Botones

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtBoxUser.Text != "Username")
            {
                if(txtBoxPass.Text != "123456")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.loginUser(txtBoxUser.Text, txtBoxPass.Text);
                    if (validLogin == true) 
                    {
                        Main mainMenu = new Main();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario y/o Contraseña no son correctos.");
                        txtBoxPass.Clear();
                        txtBoxUser.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese una contraseña.");
                }
            }
            else
            {
                msgError("Ingrese su nombre de usuario.");
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = false;
            if (txtBoxPass.UseSystemPasswordChar == false)
            {
                btnVisible.Visible = false;
                btnInvisible.Visible = true;
            }
        }
        private void btnInvisible_Click(object sender, EventArgs e)
        {
            txtBoxPass.UseSystemPasswordChar = true;
            if (txtBoxPass.UseSystemPasswordChar == true)
            {
                btnInvisible.Visible = false;
                btnVisible.Visible = true;
            }
        }

        #region Links
        private void lblLinkUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register _register = new Register();
            _register.Show();
            this.Hide();
        }

        private void lblLinkOlvPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion
        #endregion

        #region Movimiento

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region Metodos

        private void msgError (string msg)
        {
            lblErrorMessage.Visible = true;
        }

        #endregion

    }
}
