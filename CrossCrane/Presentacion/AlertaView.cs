using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AlertaView : Form
    {
        
        public AlertaView(string _message)
        {
            InitializeComponent();
            message.Text = _message;
            
        }


        /// <summary>
        /// Alerts the specified message.
        /// </summary>
        /// <param name="_message">The message.</param>
        /// <param name="type">The type.</param>
        public static void Show(string message)
        {
            new Presentacion.AlertaView(message).Show();


        }

        private void alert_Load(object sender, EventArgs e)
        {
            //set position to top left...
            this.Top = -1 * (this.Height);
            //this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;


            show.Start();
        }



        int interval = 0;

        //show transition
        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 80)
            {
                this.Top += interval; // drop the alert
                interval += 2; // double the speed
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.2; //reduce opacity to zero
            }
            else
            {
                this.Close(); //then close
            }

        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            closealert.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            closealert.Start();
        }
    }
}
