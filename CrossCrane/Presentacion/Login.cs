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
using Domain.Cache;
using Domain.Business;
using Common.Cache;
using Common;

namespace Presentacion
{
    public partial class Login : Form
    {
        /*********************************************************************************/
        //Mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MoverFormLogin(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public Login()
        {
            //inicio interfaz
            InitializeComponent();
            //adjunto listado de servidores
            List<ServidorObject> servers = ServidorList.LoadServidores();
            ServerList.DataSource = servers;
            ServerList.DisplayMember = "NombreServidor";
        }

        /*********************************************************************************/
        //Botones barra titulo
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_Hover(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
        }
        private void btnMinimizar_Leave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCerrar_Hover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
        }
        private void btnCerrar_Leave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        /*********************************************************************************/
        //Usuario
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                txtUser.ForeColor = Color.DimGray;
            }
            else
            {
                txtUser.ForeColor = Color.Silver;
            }
        }
        private void txtUser_Down(object sender, MouseEventArgs e)
        {
            if (txtUser.Text != "")
            {
                txtUser.ForeColor = Color.DimGray;
            }
            else
            {
                txtUser.ForeColor = Color.Silver;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                txtUser.ForeColor = Color.DimGray;
            }
            else
            {
                txtUser.ForeColor = Color.Silver;
            }
        }

        /*********************************************************************************/
        //Password
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void txtPassword_Down(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }


        /*********************************************************************************/
        //Boton Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //valido datos
            if (ValidateInputs() == true)
            {
                this.txtUserNotFound.Visible = false;
                this.txtPasswordNotFound.Visible = false;
                this.serverSelectNotFound.Visible = false;

                //Envio datos a la capa dominio
                UserModel user = new UserModel();
                var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text, ServerList.Text);
                //Si hay datos
                if (validLogin == true)
                {
                    //Si esta activo
                    if (UserCache.idEstado == 1)
                    {
                        /**********************************************/
                        //si es un superusuario se envia al selector de sistemas
                        if (UserCache.idTipoUsuario == 1)
                        {
                            //ocultar ventana login
                            this.Hide();
                            //mostrar nueva ventana
                            LoginSelect select = new LoginSelect();
                            select.Show();
                        }
                        //si no es un super usuario
                        else 
                        {
                            //verifico la cantidad de sistemas que tiene acceso
                            //si no tiene un acceso
                            if (UserCache.COunt == 0)
                            {
                                Alertas.Show("No tiene permiso de acceso a ningun sistema, Contactese con el administrador", Alertas.AlertType.error);
                            }
                            //si solo tiene un acceso
                            else if (UserCache.COunt == 1)
                            {
                                //Busco los datos del sistema
                                Query_CoreSistemasBusiness sistemas = new Query_CoreSistemasBusiness();
                                var validSystem = sistemas.ListaUnSistema(UserCache.idUsuario, UserCache.Server);
                                //Si hay datos
                                if (validSystem == true)
                                {
                                    //datos de la empresa
                                    int idSistema = UserSystem.idSistema;
                                    String Config_imgLogo = UserSystem.Config_imgLogo;
                                    String Config_IDGoogle = UserSystem.Config_IDGoogle;
                                    String RazonSocial = UserSystem.RazonSocial;

                                    //guardo los datos
                                    var validLoginSelect = user.LoginSelectSystem(idSistema, Config_imgLogo, Config_IDGoogle, RazonSocial);
                                    //Si hay datos
                                    if (validLoginSelect == true)
                                    {
                                        //ocultar ventana login select
                                        this.Hide();
                                        //mostrar nueva ventana
                                        Principal principal = new Principal();
                                        principal.Show();

                                    }
                                }
                                //Si no hay datos
                                else
                                {
                                    Alertas.Show("Datos incorrectos", Alertas.AlertType.error);
                                }
                                
                            }
                            //en caso de tener mas de un acceso, envio al index select
                            else
                            {
                                //ocultar ventana login
                                this.Hide();
                                //mostrar nueva ventana
                                LoginSelect select = new LoginSelect();
                                select.Show();
                            }
                        }


                    }
                    //si no esta activo
                    else
                    {
                        Alertas.Show("Su usuario esta desactivado, Contactese con el administrador", Alertas.AlertType.error);
                    }
                    
                }
                //Si no hay datos
                else
                {
                    Alertas.Show("Nombre de usuario o contraseña incorrecta", Alertas.AlertType.error);
                }

            }
            
        }

        /*********************************************************************************/
        //Boton Contraseña
        private void linkPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirijo a la web
            string nameServer = ServerList.Text;
            //valido la password
            if (nameServer == "Seleccione un Servidor")
            {
                this.serverSelectNotFound.Text = "* No ha seleccionado el dato obligatorio";
                this.serverSelectNotFound.Visible = true;

            }
            //Si se ha seleccionado el servidor, enviar a la pagina
            else
            {
                //llamo a las constantes
                Constantes cons = new Constantes();
                System.Diagnostics.Process.Start(cons.BaseWeb(nameServer));
            }
        }

        /*********************************************************************************/
        //Validacion de datos
        private bool ValidateInputs()
        {
            int NError = 0;
            string nameUser = txtUser.Text;
            string namePassword = txtPassword.Text;
            string nameServer = ServerList.Text;
            //valido al usuario
            if (String.IsNullOrEmpty(nameUser))
            {
                this.txtUserNotFound.Text = "* No ha ingresado el dato obligatorio";
                this.txtUserNotFound.Visible = true;
                NError++;
            }
            if (nameUser.Contains(" "))
            {
                this.txtUserNotFound.Text = "* Hay espacios en los datos";
                this.txtUserNotFound.Visible = true;
                NError++;
            }
            //valido la password
            if (String.IsNullOrEmpty(namePassword))
            {
                this.txtPasswordNotFound.Text = "* No ha ingresado el dato obligatorio";
                this.txtPasswordNotFound.Visible = true;
                NError++;
            }
            if (namePassword.Contains(" "))
            {
                this.txtPasswordNotFound.Text = "* Hay espacios en los datos";
                this.txtPasswordNotFound.Visible = true;
                NError++;
            }
            //valido la password
            if (nameServer == "Seleccione un Servidor")
            {
                this.serverSelectNotFound.Text = "* No ha seleccionado el dato obligatorio";
                this.serverSelectNotFound.Visible = true;
                NError++;
            }

            //si hay errores
            if (NError!=0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
}
