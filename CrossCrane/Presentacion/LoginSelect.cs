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
using Common.Cache;
using Domain.Business;
using Domain.Cache;
using Presentacion.Properties;

namespace Presentacion
{
    public partial class LoginSelect : Form
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

        
        public LoginSelect()
        {
            InitializeComponent();
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
        //Al cargar la ventana
        private void LoginSelect_Load(object sender, EventArgs e)
        {

            //Pongo el nombre
            labelNombre.Text = UserCache.Nombre;

            //Obtengo el listado de sistemas disponibles para el usuario
            Query_CoreSistemasBusiness sistemas = new Query_CoreSistemasBusiness();
            tableSystem.DataSource = sistemas.ListaSistema(UserCache.idUsuario, UserCache.idTipoUsuario, UserCache.Server);

            //Oculto columnas innecesarias
            tableSystem.ClearSelection();
            tableSystem.Columns[0].Visible = false;
            tableSystem.Columns[1].Visible = false;
            tableSystem.Columns[2].Visible = false;
            tableSystem.Columns[3].Visible = false;
            tableSystem.Columns[4].Width = 200;
            tableSystem.Columns[4].HeaderText = "Empresa";

            // Add a button column. 
            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.HeaderText = "Acciones";
            buttonColumn.Name = "Acciones";
            buttonColumn.Image = Properties.Resources.table_system_select;
            tableSystem.Columns.Add(buttonColumn);
            tableSystem.Columns[5].Width = 100;


        }

        private void tableSystem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableSystem.Rows[e.RowIndex].Cells["Acciones"].Selected)
            {
                
                int idSistema          = int.Parse(tableSystem.Rows[e.RowIndex].Cells[1].Value.ToString());
                String Config_imgLogo  = tableSystem.Rows[e.RowIndex].Cells[2].Value.ToString();
                String Config_IDGoogle = tableSystem.Rows[e.RowIndex].Cells[3].Value.ToString();
                String RazonSocial     = tableSystem.Rows[e.RowIndex].Cells[4].Value.ToString();

                //Envio datos a la capa dominio
                UserModel user = new UserModel();
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
                //Si no hay datos
                else
                {
                    Alertas.Show("Datos incorrectos", Alertas.AlertType.error);
                }

            }
        }



    }
}
