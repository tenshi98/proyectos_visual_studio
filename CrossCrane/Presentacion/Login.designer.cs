
namespace Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkPassword = new System.Windows.Forms.LinkLabel();
            this.txtUserNotFound = new System.Windows.Forms.Label();
            this.txtPasswordNotFound = new System.Windows.Forms.Label();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerList = new Bunifu.UI.WinForms.BunifuDropdown();
            this.serverSelectNotFound = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(300, 36);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverFormLogin);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnMinimizar.BackgroundImage = global::Presentacion.Properties.Resources.barra_titulo_btn_minimize;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(237, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_Leave);
            this.btnMinimizar.MouseHover += new System.EventHandler(this.btnMinimizar_Hover);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnCerrar.BackgroundImage = global::Presentacion.Properties.Resources.barra_titulo_btn_close;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(267, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_Leave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_Hover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inicio Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // linkPassword
            // 
            this.linkPassword.AutoSize = true;
            this.linkPassword.LinkColor = System.Drawing.Color.DarkGray;
            this.linkPassword.Location = new System.Drawing.Point(64, 540);
            this.linkPassword.Name = "linkPassword";
            this.linkPassword.Size = new System.Drawing.Size(146, 13);
            this.linkPassword.TabIndex = 12;
            this.linkPassword.TabStop = true;
            this.linkPassword.Text = "¿Ha olvidado su contraseña?";
            this.linkPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPassword_LinkClicked);
            // 
            // txtUserNotFound
            // 
            this.txtUserNotFound.AutoSize = true;
            this.txtUserNotFound.BackColor = System.Drawing.Color.Transparent;
            this.txtUserNotFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNotFound.ForeColor = System.Drawing.Color.Red;
            this.txtUserNotFound.Location = new System.Drawing.Point(34, 231);
            this.txtUserNotFound.Name = "txtUserNotFound";
            this.txtUserNotFound.Size = new System.Drawing.Size(109, 15);
            this.txtUserNotFound.TabIndex = 13;
            this.txtUserNotFound.Text = "Datos Obligatorios";
            this.txtUserNotFound.Visible = false;
            // 
            // txtPasswordNotFound
            // 
            this.txtPasswordNotFound.AutoSize = true;
            this.txtPasswordNotFound.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordNotFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNotFound.ForeColor = System.Drawing.Color.Red;
            this.txtPasswordNotFound.Location = new System.Drawing.Point(34, 319);
            this.txtPasswordNotFound.Name = "txtPasswordNotFound";
            this.txtPasswordNotFound.Size = new System.Drawing.Size(109, 15);
            this.txtPasswordNotFound.TabIndex = 14;
            this.txtPasswordNotFound.Text = "Datos Obligatorios";
            this.txtPasswordNotFound.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.AnimationSpeed = 200;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUser.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 1;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUser.IconLeft")));
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = null;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(20, 192);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUser.Modified = false;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnIdleState = stateProperties4;
            this.txtUser.Padding = new System.Windows.Forms.Padding(3);
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.ReadOnly = false;
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(260, 37);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUser.TabIndex = 11;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginBottom = 0;
            this.txtUser.TextMarginLeft = 3;
            this.txtUser.TextMarginTop = 0;
            this.txtUser.TextPlaceholder = "Usuario";
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.WordWrap = true;
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUser_Down);
            this.txtUser.MouseEnter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "Iniciar Sesion";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges1;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.IdleBorderRadius = 5;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.IdleIconLeftImage")));
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(20, 481);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.OnDisabledState.BorderRadius = 5;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 1;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(253)))));
            this.btnLogin.onHoverState.BorderRadius = 5;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 1;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(63)))), ((int)(((byte)(253)))));
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.OnIdleState.BorderRadius = 5;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 1;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.OnIdleState.IconLeftImage")));
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(10)))), ((int)(((byte)(204)))));
            this.btnLogin.OnPressedState.BorderRadius = 5;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 1;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(10)))), ((int)(((byte)(204)))));
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(260, 39);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 1;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(20, 280);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(260, 37);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Contraseña";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            this.txtPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPassword_Down);
            this.txtPassword.MouseEnter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Presentacion.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Servidor";
            // 
            // ServerList
            // 
            this.ServerList.BackColor = System.Drawing.Color.Transparent;
            this.ServerList.BackgroundColor = System.Drawing.Color.White;
            this.ServerList.BorderColor = System.Drawing.Color.Silver;
            this.ServerList.BorderRadius = 1;
            this.ServerList.Color = System.Drawing.Color.Silver;
            this.ServerList.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ServerList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ServerList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ServerList.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ServerList.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerList.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ServerList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServerList.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerList.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ServerList.FillDropDown = true;
            this.ServerList.FillIndicator = false;
            this.ServerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerList.ForeColor = System.Drawing.Color.Black;
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Icon = null;
            this.ServerList.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ServerList.IndicatorColor = System.Drawing.Color.Gray;
            this.ServerList.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ServerList.ItemBackColor = System.Drawing.Color.White;
            this.ServerList.ItemBorderColor = System.Drawing.Color.White;
            this.ServerList.ItemForeColor = System.Drawing.Color.Black;
            this.ServerList.ItemHeight = 26;
            this.ServerList.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ServerList.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ServerList.ItemTopMargin = 3;
            this.ServerList.Location = new System.Drawing.Point(20, 369);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(260, 32);
            this.ServerList.TabIndex = 19;
            this.ServerList.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ServerList.TextLeftMargin = 5;
            // 
            // serverSelectNotFound
            // 
            this.serverSelectNotFound.AutoSize = true;
            this.serverSelectNotFound.BackColor = System.Drawing.Color.Transparent;
            this.serverSelectNotFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSelectNotFound.ForeColor = System.Drawing.Color.Red;
            this.serverSelectNotFound.Location = new System.Drawing.Point(34, 405);
            this.serverSelectNotFound.Name = "serverSelectNotFound";
            this.serverSelectNotFound.Size = new System.Drawing.Size(109, 15);
            this.serverSelectNotFound.TabIndex = 20;
            this.serverSelectNotFound.Text = "Datos Obligatorios";
            this.serverSelectNotFound.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(86)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(300, 578);
            this.Controls.Add(this.serverSelectNotFound);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordNotFound);
            this.Controls.Add(this.txtUserNotFound);
            this.Controls.Add(this.linkPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private Bunifu.UI.WinForms.BunifuTextBox txtUser;
        private System.Windows.Forms.LinkLabel linkPassword;
        private System.Windows.Forms.Label txtUserNotFound;
        private System.Windows.Forms.Label txtPasswordNotFound;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown ServerList;
        private System.Windows.Forms.Label serverSelectNotFound;
    }
}

