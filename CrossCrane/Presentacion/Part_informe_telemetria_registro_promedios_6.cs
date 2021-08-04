using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Common;
using Common.Entities;
using Domain.Business;

namespace Presentacion
{
    public partial class Part_informe_telemetria_registro_promedios_6 : Form
    {
        public Part_informe_telemetria_registro_promedios_6()
        {
            InitializeComponent();

            Form_Load();



        }
        public void Form_Load()
        {
            //Centro el formulario de busqueda
            FormPanel.Location = new Point(
                FilterPanel.Width / 2 - FormPanel.Size.Width / 2,
                FilterPanel.Height / 2 - FormPanel.Size.Height / 2);
            FormPanel.Anchor = AnchorStyles.None;

            //agrego controles
            h_inicio.ShowUpDown = true;
            h_termino.ShowUpDown = true;

            /********************************************************************/
            //genero la consulta
            String SIS_query = "telemetria_listado.idTelemetria, telemetria_listado.Nombre";
            String SIS_from = "telemetria_listado";
            String SIS_join = "";
            String SIS_where = "telemetria_listado.idSistema=" + UserCache.idSistema + " AND telemetria_listado.id_Geo=2 AND telemetria_listado.id_Sensores=1 AND telemetria_listado.idTab=2";
            String SIS_order = "telemetria_listado.Nombre ASC";
           
            //Verifico el tipo de usuario que esta ingresando para mostrar solo 
            if (UserCache.idTipoUsuario != 1){
                SIS_where  = SIS_where + " AND usuarios_equipos_telemetria.idUsuario = " + UserCache.idUsuario;
                SIS_join = "LEFT JOIN usuarios_equipos_telemetria ON usuarios_equipos_telemetria.idTelemetria = telemetria_listado.idTelemetria";
            }
            //Adjunto los equipos
            Load_SelectBusiness Select = new Load_SelectBusiness();
            idTelemetria.DataSource = Select.SelectList(SIS_query, SIS_from, SIS_join, SIS_where, SIS_order, UserCache.Server);
            idTelemetria.DisplayMember = "Nombre";
            idTelemetria.ValueMember = "id";

            /********************************************************************/
            //adjunto listado
            List<ColumnaObject> Opciones = ColumnaList.LoadData("Temperatura,Humedad");
            idOpciones.DataSource = Opciones;
            idOpciones.DisplayMember = "Nombre";
            idOpciones.ValueMember = "ID";

            /********************************************************************/
            //adjunto listado
            List<ColumnaObject> Grafico = ColumnaList.LoadData("Si,No");
            idGrafico.DataSource = Grafico;
            idGrafico.DisplayMember = "Nombre";
            idGrafico.ValueMember = "ID";

        }

       
        protected void idTelemetria_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string sel = DropDownList1.SelectedValue.ToString();
            if (DropDownList1.SelectedIndex == 1)
             {
            using (SqlConnection con = new SqlConnection(DBcon))
            {

                SqlCommand sqlCommand = new SqlCommand("Select * from tbl_WinApps_FileHeader");
                sqlCommand.Connection = con;
                SqlDataReader read = sqlCommand.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            }*/
            Alertas.Show("id idTelemetria:" + idTelemetria.SelectedValue.ToString(), Alertas.AlertType.error);
        }

        protected void idOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string sel = DropDownList1.SelectedValue.ToString();
            if (DropDownList1.SelectedIndex == 1)
             {
            using (SqlConnection con = new SqlConnection(DBcon))
            {

                SqlCommand sqlCommand = new SqlCommand("Select * from tbl_WinApps_FileHeader");
                sqlCommand.Connection = con;
                SqlDataReader read = sqlCommand.ExecuteReader();
                GridView1.DataSource = read;
                GridView1.DataBind();
            }
            }*/
            Alertas.Show("id idTelemetria:" + idOpciones.SelectedValue.ToString(), Alertas.AlertType.error);
        }
        /*******************************************************************/
        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
