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
using Common;
using Common.Entities;
using Domain.Business;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System.Net;

namespace Presentacion
{
    public partial class Principal : Form
    {

        //Variables
        int lx, ly;
        int sw, sh;
        int AnchoMenu = 260;
        int AnchoMiniMenu = 60;

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

        public Principal()
        {
            InitializeComponent();
            hideSubMenus();
            softData();
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
        /***************************************/
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnMaximizar_Hover(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
        }
        private void btnMaximizar_Leave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        /***************************************/
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnRestaurar_Hover(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
        }
        private void btnRestaurar_Leave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        /***************************************/
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            AlertaView frm = new AlertaView("¿Realmente desea cerrar su sesion?");
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnCerrar_Hover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
        }
        private void btnCerrar_Leave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        /***************************************/
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Reinicio menus
            hideSubMenus();
            //ejecuto
            if (panelMenu.Width == AnchoMenu)
            {
                this.ContraerMenu.Start();
            }
            else if (panelMenu.Width == AnchoMiniMenu)
            {
                this.ExpandirMenu.Start();
            }
        }
        private void btnMenu_Hover(object sender, EventArgs e)
        {
            btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
        }
        private void btnMenu_Leave(object sender, EventArgs e)
        {
            btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
        }
        private void ExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= AnchoMenu)
            {
                this.ExpandirMenu.Stop();
            }
            else
            {
                panelMenu.Width = panelMenu.Width + 10;
            }
        }
        private void ContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= AnchoMiniMenu)
            {
                this.ContraerMenu.Stop();
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 10;
            }
        }


        /***************************************/
        private void hideSubMenus()
        {
            SubMenu1.Visible = false;
            SubMenu2.Visible = false;
            SubMenu3.Visible = false;
            SubMenu4.Visible = false;
            SubMenu5.Visible = false;
            SubMenu6.Visible = false;
            SubMenu7.Visible = false;
            SubMenu8.Visible = false;
        }
        private void showSubMenu(DataGridView subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        /***************************************/
        private void softData()
        {

            Constantes cons = new Constantes();

            //Imagen del usuario, si la hay
            if (UserCache.Direccion_img!="")
            {
                var request = WebRequest.Create(UserCache.BaseWeb + "upload/" + UserCache.Direccion_img);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    UserImage.Image = Bitmap.FromStream(stream);
                }
            }
            

            //Nombre del usuario
            labelNombre.Text = UserCache.Nombre;

            //Nombre del software
            NombreSoftware.Text = UserCache.Server + " | " + UserCache.RazonSocial + " - " + cons.SoftData(1) + " (" + cons.SoftData(5) +")";

            //Se carga Menu
            /*
             29 - Informes Cross
             40 - Informes CrossC
             38 - Informes CrossChecking
             54 - Informes CrossCrane
             42 - Informes CrossTrack
             44 - Informes CrossWeather
             13 - Informes Gerenciales
             9  - Informes Telemetria
             */

            //llamo al constructor
            Query_UserMenuBusiness menu = new Query_UserMenuBusiness();
            List<Query_UserMenuEntities> listing = new List<Query_UserMenuEntities>();
            //obtengo el menu
            listing = menu.ListaMenu(UserCache.idUsuario, UserCache.idTipoUsuario, UserCache.Server);
            
            //Ejecuto logica (Mantener los espacios)
            showSubMenuColumns(SubMenu1, Button1, listing, 29, "                    Informes Cross");
            showSubMenuColumns(SubMenu2, Button2, listing, 40, "                    Informes CrossC");
            showSubMenuColumns(SubMenu3, Button3, listing, 38, "                    Informes CrossChecking");
            showSubMenuColumns(SubMenu4, Button4, listing, 54, "                    Informes CrossCrane");
            showSubMenuColumns(SubMenu5, Button5, listing, 42, "                    Informes CrossTrack");
            showSubMenuColumns(SubMenu6, Button6, listing, 44, "                    Informes CrossWeather");
            showSubMenuColumns(SubMenu7, Button7, listing, 13, "                    Informes Gerenciales");
            showSubMenuColumns(SubMenu8, Button8, listing,  9, "                    Informes Telemetria");

        }

        private void showSubMenuColumns(BunifuDataGridView subMenu, BunifuButton catMenu, List<Query_UserMenuEntities> listing, int cat, String NombreBoton)
        {
            //Seteo el nombre del boton
            catMenu.Text = NombreBoton;

            //Traspaso la info al submenu
            var Category = listing.Where(user => user.TransaccionCat.Equals(cat));
            //Le agrego columnas a las tablas
            subMenu.Columns.Add("Column1", "Nombre");
            subMenu.Columns.Add("Column2", "LevelLimit");
            subMenu.Columns.Add("Column3", "idPermiso");
            //asigno valores
            foreach (Query_UserMenuEntities subcat in Category)
            {
                var index = subMenu.Rows.Add();
                //reemplazo de texto
                string TransaccionNombre = subcat.TransaccionNombre;
                TransaccionNombre = TransaccionNombre.Replace("0 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("1 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("2 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("3 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("4 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("5 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("6 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("7 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("8 - ", "");
                TransaccionNombre = TransaccionNombre.Replace("9 - ", "");
                //se guardan los datos
                subMenu.Rows[index].Cells["Column1"].Value = TransaccionNombre;
                subMenu.Rows[index].Cells["Column2"].Value = subcat.level;
                subMenu.Rows[index].Cells["Column3"].Value = subcat.idAdmpm;
                
            }

            //Oculto columnas innecesarias
            subMenu.ClearSelection();
            subMenu.Columns[1].Visible = false;
            subMenu.Columns[2].Visible = false;

            //calculo el alto del submenu en base a la cantidad de items
            int calc = 40 * int.Parse(subMenu.Rows.Count.ToString());
            if (calc < 290)
            {
                subMenu.Height = calc;
            }
            else
            {
                subMenu.Height = 290;
            }

            //oculto la categoria si esta tiene 0 items
            if (calc==0)
            {
                catMenu.Visible = false;
            }
            
        }

        /***************************************/
        private void Button1_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu1);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu2);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu3);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu4);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu5);
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu6);
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu7);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            this.ExpandirMenu.Start();
            showSubMenu(SubMenu8);
        }

        /***************************************/
        private void MenuSeleccionado_1(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu1.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_2(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu2.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_3(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu3.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_4(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu4.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_5(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu5.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_6(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu6.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_7(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu7.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        private void MenuSeleccionado_8(object sender, DataGridViewCellEventArgs e)
        {
            MenuAction(int.Parse(SubMenu8.Rows[e.RowIndex].Cells[2].Value.ToString()));
        }
        /***************************************/
        private void MenuAction(int Permiso)
        {
            //Oculto Menus
            hideSubMenus();
            this.ContraerMenu.Start();

            //
            switch (Permiso)
            {
                /********************************************/
                //Informes Cross
                case 365: openChildForm(new Part_1_noData()); break;
                case 318: openChildForm(new Part_1_noData()); break;
                /********************************************/
                //Informes CrossC
                case 412: openChildForm(new Part_informe_telemetria_registro_promedios_6()); break;
                case 431: openChildForm(new Part_1_noData()); break;
                case 411: openChildForm(new Part_1_noData()); break;
                case 417: openChildForm(new Part_1_noData()); break;
                case 420: openChildForm(new Part_1_noData()); break;
                case 116: openChildForm(new Part_1_noData()); break;
                case 65: openChildForm(new Part_1_noData()); break;
                case 60: openChildForm(new Part_1_noData()); break;
                case 62: openChildForm(new Part_1_noData()); break;
                case 113: openChildForm(new Part_1_noData()); break;
                case 117: openChildForm(new Part_1_noData()); break;
                case 68: openChildForm(new Part_1_noData()); break;
                /********************************************/
                //Informes CrossChecking
                case 406: openChildForm(new Part_1_noData()); break;
                case 363: openChildForm(new Part_1_noData()); break;
                case 361: openChildForm(new Part_1_noData()); break;
                case 359: openChildForm(new Part_1_noData()); break;
                case 340: openChildForm(new Part_1_noData()); break;
                case 339: openChildForm(new Part_1_noData()); break;
                case 356: openChildForm(new Part_1_noData()); break;
                case 480: openChildForm(new Part_1_noData()); break;
                case 415: openChildForm(new Part_1_noData()); break;
                /********************************************/
                //Informes CrossCrane
                case 481: openChildForm(new Part_1_noData()); break;
                case 484: openChildForm(new Part_1_noData()); break;
                case 483: openChildForm(new Part_1_noData()); break;
                case 482: openChildForm(new Part_1_noData()); break;
                case 486: openChildForm(new Part_1_noData()); break;
                case 549: openChildForm(new Part_1_noData()); break;
                case 485: openChildForm(new Part_1_noData()); break;
                /********************************************/
                //Informes CrossTrack
                case 59: openChildForm(new Part_1_noData()); break;
                case 58: openChildForm(new Part_1_noData()); break;
                case 112: openChildForm(new Part_1_noData()); break;
                case 413: openChildForm(new Part_1_noData()); break;
                case 61: openChildForm(new Part_1_noData()); break;
                case 63: openChildForm(new Part_1_noData()); break;
                case 115: openChildForm(new Part_1_noData()); break;
                case 64: openChildForm(new Part_1_noData()); break;
                case 371: openChildForm(new Part_1_noData()); break;
                case 118: openChildForm(new Part_1_noData()); break;
                case 67: openChildForm(new Part_1_noData()); break;
                case 66: openChildForm(new Part_1_noData()); break;
                case 370: openChildForm(new Part_1_noData()); break;
                case 69: openChildForm(new Part_1_noData()); break;
                /********************************************/
                //Informes CrossWeather
                case 418: openChildForm(new Part_1_noData()); break;
                case 419: openChildForm(new Part_1_noData()); break;
                case 450: openChildForm(new Part_1_noData()); break;
                case 458: openChildForm(new Part_1_noData()); break;
                case 414: openChildForm(new Part_1_noData()); break;
                case 459: openChildForm(new Part_1_noData()); break;
                case 462: openChildForm(new Part_1_noData()); break;
                case 461: openChildForm(new Part_1_noData()); break;
                case 464: openChildForm(new Part_1_noData()); break;






                default:
                    openChildForm(new Part_1_noData());
                    break;

            }

            

        }

        private void ButtonPrincipal_Click(object sender, EventArgs e)
        {

        }

        /***************************************/
        //funcion para abrir formulario en la app
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



    }
}
