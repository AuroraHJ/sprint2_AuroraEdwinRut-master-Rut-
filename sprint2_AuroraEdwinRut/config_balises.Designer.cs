
namespace sprint2_AuroraEdwinRut
{
    partial class config_balises
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
            this.components = new System.ComponentModel.Container();
            this.lbl_ports = new System.Windows.Forms.Label();
            this.lbl_grups = new System.Windows.Forms.Label();
            this.lbl_divisor = new System.Windows.Forms.Label();
            this.pnl_config = new System.Windows.Forms.Panel();
            this.lbl_inc_divisor = new System.Windows.Forms.Label();
            this.lbl_inc_cicle = new System.Windows.Forms.Label();
            this.txt_divisor = new System.Windows.Forms.TextBox();
            this.txt_cicle = new System.Windows.Forms.TextBox();
            this.btn_config = new System.Windows.Forms.Button();
            this.cmb_ports = new System.Windows.Forms.ComboBox();
            this.btn_connectar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ports
            // 
            this.lbl_ports.AutoSize = true;
            this.lbl_ports.Location = new System.Drawing.Point(176, 57);
            this.lbl_ports.Name = "lbl_ports";
            this.lbl_ports.Size = new System.Drawing.Size(86, 13);
            this.lbl_ports.TabIndex = 0;
            this.lbl_ports.Text = "Ports disponibles";
            // 
            // lbl_grups
            // 
            this.lbl_grups.AutoSize = true;
            this.lbl_grups.Location = new System.Drawing.Point(62, 22);
            this.lbl_grups.Name = "lbl_grups";
            this.lbl_grups.Size = new System.Drawing.Size(60, 13);
            this.lbl_grups.TabIndex = 1;
            this.lbl_grups.Text = "Grups cicle";
            // 
            // lbl_divisor
            // 
            this.lbl_divisor.AutoSize = true;
            this.lbl_divisor.Location = new System.Drawing.Point(71, 73);
            this.lbl_divisor.Name = "lbl_divisor";
            this.lbl_divisor.Size = new System.Drawing.Size(39, 13);
            this.lbl_divisor.TabIndex = 2;
            this.lbl_divisor.Text = "Divisor";
            // 
            // pnl_config
            // 
            this.pnl_config.Controls.Add(this.lbl_inc_divisor);
            this.pnl_config.Controls.Add(this.lbl_inc_cicle);
            this.pnl_config.Controls.Add(this.txt_divisor);
            this.pnl_config.Controls.Add(this.txt_cicle);
            this.pnl_config.Controls.Add(this.btn_config);
            this.pnl_config.Controls.Add(this.lbl_grups);
            this.pnl_config.Controls.Add(this.lbl_divisor);
            this.pnl_config.Location = new System.Drawing.Point(152, 144);
            this.pnl_config.Name = "pnl_config";
            this.pnl_config.Size = new System.Drawing.Size(472, 122);
            this.pnl_config.TabIndex = 3;
            // 
            // lbl_inc_divisor
            // 
            this.lbl_inc_divisor.AutoSize = true;
            this.lbl_inc_divisor.Location = new System.Drawing.Point(138, 93);
            this.lbl_inc_divisor.Name = "lbl_inc_divisor";
            this.lbl_inc_divisor.Size = new System.Drawing.Size(55, 13);
            this.lbl_inc_divisor.TabIndex = 10;
            this.lbl_inc_divisor.Text = "Incorrecte";
            this.lbl_inc_divisor.Visible = false;
            // 
            // lbl_inc_cicle
            // 
            this.lbl_inc_cicle.AutoSize = true;
            this.lbl_inc_cicle.Location = new System.Drawing.Point(138, 42);
            this.lbl_inc_cicle.Name = "lbl_inc_cicle";
            this.lbl_inc_cicle.Size = new System.Drawing.Size(55, 13);
            this.lbl_inc_cicle.TabIndex = 9;
            this.lbl_inc_cicle.Text = "Incorrecte";
            this.lbl_inc_cicle.Visible = false;
            // 
            // txt_divisor
            // 
            this.txt_divisor.Location = new System.Drawing.Point(141, 70);
            this.txt_divisor.Name = "txt_divisor";
            this.txt_divisor.Size = new System.Drawing.Size(100, 20);
            this.txt_divisor.TabIndex = 8;
            this.txt_divisor.Validating += new System.ComponentModel.CancelEventHandler(this.txt_divisor_Validating);
            // 
            // txt_cicle
            // 
            this.txt_cicle.Location = new System.Drawing.Point(141, 19);
            this.txt_cicle.MaxLength = 2;
            this.txt_cicle.Name = "txt_cicle";
            this.txt_cicle.Size = new System.Drawing.Size(100, 20);
            this.txt_cicle.TabIndex = 7;
            this.txt_cicle.Validating += new System.ComponentModel.CancelEventHandler(this.txt_validating);
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(295, 17);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(75, 23);
            this.btn_config.TabIndex = 6;
            this.btn_config.Text = "Configurar";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // cmb_ports
            // 
            this.cmb_ports.FormattingEnabled = true;
            this.cmb_ports.Location = new System.Drawing.Point(268, 54);
            this.cmb_ports.Name = "cmb_ports";
            this.cmb_ports.Size = new System.Drawing.Size(121, 21);
            this.cmb_ports.TabIndex = 4;
            this.cmb_ports.Enter += new System.EventHandler(this.cmb_ports_Enter);
            // 
            // btn_connectar
            // 
            this.btn_connectar.Location = new System.Drawing.Point(447, 51);
            this.btn_connectar.Name = "btn_connectar";
            this.btn_connectar.Size = new System.Drawing.Size(75, 23);
            this.btn_connectar.TabIndex = 5;
            this.btn_connectar.Text = "Connectar";
            this.btn_connectar.UseVisualStyleBackColor = true;
            this.btn_connectar.Click += new System.EventHandler(this.btn_connectar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // config_balises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_connectar);
            this.Controls.Add(this.cmb_ports);
            this.Controls.Add(this.pnl_config);
            this.Controls.Add(this.lbl_ports);
            this.Name = "config_balises";
            this.Text = "Configuració de balises";
            this.pnl_config.ResumeLayout(false);
            this.pnl_config.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ports;
        private System.Windows.Forms.Label lbl_grups;
        private System.Windows.Forms.Label lbl_divisor;
        private System.Windows.Forms.Panel pnl_config;
        private System.Windows.Forms.TextBox txt_divisor;
        private System.Windows.Forms.TextBox txt_cicle;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.ComboBox cmb_ports;
        private System.Windows.Forms.Button btn_connectar;
        private System.Windows.Forms.Label lbl_inc_cicle;
        private System.Windows.Forms.Label lbl_inc_divisor;
        private System.Windows.Forms.Timer timer1;
    }
}

