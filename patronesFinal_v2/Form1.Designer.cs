
namespace patronesFinal_v2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_header = new System.Windows.Forms.PictureBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.pic_nav_bar = new System.Windows.Forms.PictureBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_User = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.txb_user = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_saludo_bienvenida = new System.Windows.Forms.Label();
            this.lb_nombre_banco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nav_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_header
            // 
            this.pic_header.Image = ((System.Drawing.Image)(resources.GetObject("pic_header.Image")));
            this.pic_header.Location = new System.Drawing.Point(-2, -3);
            this.pic_header.Name = "pic_header";
            this.pic_header.Size = new System.Drawing.Size(252, 125);
            this.pic_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_header.TabIndex = 2;
            this.pic_header.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_close.BackgroundImage")));
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Location = new System.Drawing.Point(-2, 461);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(252, 36);
            this.bt_close.TabIndex = 19;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // pic_nav_bar
            // 
            this.pic_nav_bar.Image = ((System.Drawing.Image)(resources.GetObject("pic_nav_bar.Image")));
            this.pic_nav_bar.Location = new System.Drawing.Point(-2, 461);
            this.pic_nav_bar.Name = "pic_nav_bar";
            this.pic_nav_bar.Size = new System.Drawing.Size(252, 36);
            this.pic_nav_bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nav_bar.TabIndex = 18;
            this.pic_nav_bar.TabStop = false;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(31, 281);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(91, 17);
            this.lb_Password.TabIndex = 17;
            this.lb_Password.Text = "CONTRASEÑA";
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(31, 228);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(62, 17);
            this.lb_User.TabIndex = 16;
            this.lb_User.Text = "USUARIO";
            // 
            // txb_pass
            // 
            this.txb_pass.Location = new System.Drawing.Point(34, 301);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(169, 20);
            this.txb_pass.TabIndex = 15;
            // 
            // txb_user
            // 
            this.txb_user.Location = new System.Drawing.Point(34, 248);
            this.txb_user.Name = "txb_user";
            this.txb_user.Size = new System.Drawing.Size(169, 20);
            this.txb_user.TabIndex = 14;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(49, 352);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(144, 38);
            this.bt_login.TabIndex = 13;
            this.bt_login.Text = "INICIAR SESION";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_saludo_bienvenida
            // 
            this.lb_saludo_bienvenida.AutoSize = true;
            this.lb_saludo_bienvenida.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saludo_bienvenida.Location = new System.Drawing.Point(46, 184);
            this.lb_saludo_bienvenida.Name = "lb_saludo_bienvenida";
            this.lb_saludo_bienvenida.Size = new System.Drawing.Size(157, 16);
            this.lb_saludo_bienvenida.TabIndex = 12;
            this.lb_saludo_bienvenida.Text = "BIENVENIDO DE NUEVO";
            // 
            // lb_nombre_banco
            // 
            this.lb_nombre_banco.AutoSize = true;
            this.lb_nombre_banco.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_banco.Location = new System.Drawing.Point(50, 152);
            this.lb_nombre_banco.Name = "lb_nombre_banco";
            this.lb_nombre_banco.Size = new System.Drawing.Size(143, 32);
            this.lb_nombre_banco.TabIndex = 11;
            this.lb_nombre_banco.Text = "BANCOFY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 495);
            this.ControlBox = false;
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.pic_nav_bar);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.txb_user);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_saludo_bienvenida);
            this.Controls.Add(this.lb_nombre_banco);
            this.Controls.Add(this.pic_header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nav_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_header;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.PictureBox pic_nav_bar;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.TextBox txb_user;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_saludo_bienvenida;
        private System.Windows.Forms.Label lb_nombre_banco;
    }
}

