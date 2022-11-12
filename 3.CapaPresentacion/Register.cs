using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _3.CapaPresentacion
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        #region Botones

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

        private void btnRInvisible_Click(object sender, EventArgs e)
        {
            txtBoxRPass.UseSystemPasswordChar = true;
            if (txtBoxRPass.UseSystemPasswordChar == true)
            {
                btnRInvisible.Visible = false;
                btnRVisible.Visible = true;
            }
        }

        private void btnRVisible_Click(object sender, EventArgs e)
        {
            txtBoxRPass.UseSystemPasswordChar = true;
            if (txtBoxRPass.UseSystemPasswordChar == true)
            {
                btnRInvisible.Visible = false;
                btnRVisible.Visible = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*if (txtBoxPass.Text == txtBoxRPass.Text)
            {
                clsAdminUsers adminUsers = new clsAdminUsers();
                adminUsers.Agregar(usersDatos());

                Login _login = new Login();
                _login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las contrasenas no coinciden");
            }*/
        }

        #endregion
        #region TxtBoxs

        private void txtBoxUser_Enter(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "Ejemplo123")
            {
                txtBoxUser.Text = "";
                txtBoxUser.ForeColor = Color.White;
            }
        }

        private void txtBoxUser_Leave(object sender, EventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "Ejemplo123";
                txtBoxUser.ForeColor = Color.DimGray;
            }
        }

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

        private void txtBoxRPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxRPass.Text == "123456")
            {
                txtBoxRPass.Text = "";
                txtBoxRPass.ForeColor = Color.White;
            }
        }

        private void txtBoxRPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxRPass.Text == "")
            {
                txtBoxRPass.Text = "123456";
                txtBoxRPass.ForeColor = Color.DimGray;
            }
        }

        private void txtBoxFName_Enter(object sender, EventArgs e)
        {
            if (txtBoxFName.Text == "Giuliano")
            {
                txtBoxFName.Text = "";
                txtBoxFName.ForeColor = Color.White;
            }
        }

        private void txtBoxFName_Leave(object sender, EventArgs e)
        {
            if (txtBoxFName.Text == "")
            {
                txtBoxFName.Text = "Giuliano";
                txtBoxFName.ForeColor = Color.DimGray;
            }
        }

        private void txtBoxLName_Enter(object sender, EventArgs e)
        {
            if (txtBoxLName.Text == "Colella")
            {
                txtBoxLName.Text = "";
                txtBoxLName.ForeColor = Color.White;
            }
        }

        private void txtBoxLName_Leave(object sender, EventArgs e)
        {
            if (txtBoxLName.Text == "")
            {
                txtBoxLName.Text = "Colella";
                txtBoxLName.ForeColor = Color.DimGray;
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Support@SystemAll.biz")
            {
                txtBoxEmail.Text = "";
                txtBoxEmail.ForeColor = Color.White;
            }
        }

        private void txtBoxEmail_Leave(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "Support@SystemAll.biz";
                txtBoxEmail.ForeColor = Color.DimGray;
            }
        }

        #endregion
        #region Movimiento

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


    }
}
