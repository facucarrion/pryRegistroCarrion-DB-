namespace pryRegistroCarrion_DB_
{
    partial class frmBuscarCliente
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMostrarDeuda = new System.Windows.Forms.Label();
            this.lblMostrarLimite = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(62, 10);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(238, 8);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(105, 23);
            this.btnCodigo.TabIndex = 2;
            this.btnCodigo.Text = "Buscar";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblLimite);
            this.gbCliente.Controls.Add(this.lblDeuda);
            this.gbCliente.Controls.Add(this.lblMostrarLimite);
            this.gbCliente.Controls.Add(this.lblMostrarDeuda);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblMostrarNombre);
            this.gbCliente.Location = new System.Drawing.Point(16, 36);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(327, 134);
            this.gbCliente.TabIndex = 3;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            this.gbCliente.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarNombre.Location = new System.Drawing.Point(206, 36);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(103, 15);
            this.lblMostrarNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMostrarDeuda
            // 
            this.lblMostrarDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarDeuda.Location = new System.Drawing.Point(206, 69);
            this.lblMostrarDeuda.Name = "lblMostrarDeuda";
            this.lblMostrarDeuda.Size = new System.Drawing.Size(103, 15);
            this.lblMostrarDeuda.TabIndex = 2;
            // 
            // lblMostrarLimite
            // 
            this.lblMostrarLimite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrarLimite.Location = new System.Drawing.Point(206, 103);
            this.lblMostrarLimite.Name = "lblMostrarLimite";
            this.lblMostrarLimite.Size = new System.Drawing.Size(103, 15);
            this.lblMostrarLimite.TabIndex = 3;
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(15, 69);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 4;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(15, 103);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(84, 13);
            this.lblLimite.TabIndex = 5;
            this.lblLimite.Text = "Límite crediticio:";
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblMostrarLimite;
        private System.Windows.Forms.Label lblMostrarDeuda;
        private System.Windows.Forms.Label lblNombre;
    }
}