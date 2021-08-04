
namespace Presentacion
{
    partial class AlertaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertaView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.closealert = new System.Windows.Forms.Timer(this.components);
            this.message = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuccess = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // show
            // 
            this.show.Interval = 1;
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // closealert
            // 
            this.closealert.Tick += new System.EventHandler(this.close_Tick);
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.DimGray;
            this.message.Location = new System.Drawing.Point(3, 9);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(320, 146);
            this.message.TabIndex = 5;
            this.message.Text = "Mensaje";
            this.message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 52);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Notificacion";
            // 
            // btnSuccess
            // 
            this.btnSuccess.AllowAnimations = true;
            this.btnSuccess.AllowMouseEffects = true;
            this.btnSuccess.AllowToggling = false;
            this.btnSuccess.AnimationSpeed = 200;
            this.btnSuccess.AutoGenerateColors = false;
            this.btnSuccess.AutoRoundBorders = false;
            this.btnSuccess.AutoSizeLeftIcon = true;
            this.btnSuccess.AutoSizeRightIcon = true;
            this.btnSuccess.BackColor = System.Drawing.Color.Transparent;
            this.btnSuccess.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSuccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuccess.BackgroundImage")));
            this.btnSuccess.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSuccess.ButtonText = "Aceptar";
            this.btnSuccess.ButtonTextMarginLeft = 0;
            this.btnSuccess.ColorContrastOnClick = 45;
            this.btnSuccess.ColorContrastOnHover = 45;
            this.btnSuccess.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSuccess.CustomizableEdges = borderEdges2;
            this.btnSuccess.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuccess.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSuccess.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSuccess.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSuccess.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSuccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuccess.ForeColor = System.Drawing.Color.White;
            this.btnSuccess.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuccess.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccess.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSuccess.IconMarginLeft = 11;
            this.btnSuccess.IconPadding = 10;
            this.btnSuccess.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuccess.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSuccess.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSuccess.IconSize = 25;
            this.btnSuccess.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSuccess.IdleBorderRadius = 5;
            this.btnSuccess.IdleBorderThickness = 1;
            this.btnSuccess.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSuccess.IdleIconLeftImage = null;
            this.btnSuccess.IdleIconRightImage = null;
            this.btnSuccess.IndicateFocus = false;
            this.btnSuccess.Location = new System.Drawing.Point(9, 190);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSuccess.OnDisabledState.BorderRadius = 5;
            this.btnSuccess.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSuccess.OnDisabledState.BorderThickness = 1;
            this.btnSuccess.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSuccess.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSuccess.OnDisabledState.IconLeftImage = null;
            this.btnSuccess.OnDisabledState.IconRightImage = null;
            this.btnSuccess.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(253)))));
            this.btnSuccess.onHoverState.BorderRadius = 5;
            this.btnSuccess.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSuccess.onHoverState.BorderThickness = 1;
            this.btnSuccess.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(253)))));
            this.btnSuccess.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSuccess.onHoverState.IconLeftImage = null;
            this.btnSuccess.onHoverState.IconRightImage = null;
            this.btnSuccess.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSuccess.OnIdleState.BorderRadius = 5;
            this.btnSuccess.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSuccess.OnIdleState.BorderThickness = 1;
            this.btnSuccess.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSuccess.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSuccess.OnIdleState.IconLeftImage = null;
            this.btnSuccess.OnIdleState.IconRightImage = null;
            this.btnSuccess.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(10)))), ((int)(((byte)(204)))));
            this.btnSuccess.OnPressedState.BorderRadius = 5;
            this.btnSuccess.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSuccess.OnPressedState.BorderThickness = 1;
            this.btnSuccess.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(10)))), ((int)(((byte)(204)))));
            this.btnSuccess.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSuccess.OnPressedState.IconLeftImage = null;
            this.btnSuccess.OnPressedState.IconRightImage = null;
            this.btnSuccess.Size = new System.Drawing.Size(150, 39);
            this.btnSuccess.TabIndex = 7;
            this.btnSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuccess.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuccess.TextMarginLeft = 0;
            this.btnSuccess.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSuccess.UseDefaultRadiusAndThickness = true;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancelar";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancel.IdleBorderRadius = 5;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(175, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 5;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 1;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(123)))));
            this.btnCancel.onHoverState.BorderRadius = 5;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 1;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(121)))), ((int)(((byte)(123)))));
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancel.OnIdleState.BorderRadius = 5;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 1;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnCancel.OnPressedState.BorderRadius = 5;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 1;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(150, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.message);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSuccess);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 256);
            this.panel2.TabIndex = 9;
            // 
            // AlertaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(340, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertaView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alertas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer closealert;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.PictureBox icon;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSuccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}