namespace Practicando
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
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCobrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.lstColaClientes = new System.Windows.Forms.ListView();
            this.txtCodigoNodo = new System.Windows.Forms.TextBox();
            this.txtImporteNodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tengoUnErrorEnMiCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miImporteNoEsValidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreInvalidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.Red;
            this.btnAgregarCliente.Location = new System.Drawing.Point(84, 217);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(136, 76);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCobrarCliente
            // 
            this.btnCobrarCliente.Location = new System.Drawing.Point(352, 503);
            this.btnCobrarCliente.Name = "btnCobrarCliente";
            this.btnCobrarCliente.Size = new System.Drawing.Size(156, 55);
            this.btnCobrarCliente.TabIndex = 1;
            this.btnCobrarCliente.Text = "Cobrar Cliente";
            this.btnCobrarCliente.UseVisualStyleBackColor = true;
            this.btnCobrarCliente.Click += new System.EventHandler(this.btnCobrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(106, 50);
            this.txtNombreNodo.Multiline = true;
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(100, 25);
            this.txtNombreNodo.TabIndex = 3;
            // 
            // lstColaClientes
            // 
            this.lstColaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstColaClientes.HideSelection = false;
            this.lstColaClientes.Location = new System.Drawing.Point(279, 33);
            this.lstColaClientes.Name = "lstColaClientes";
            this.lstColaClientes.Size = new System.Drawing.Size(289, 464);
            this.lstColaClientes.TabIndex = 4;
            this.lstColaClientes.UseCompatibleStateImageBehavior = false;
            this.lstColaClientes.View = System.Windows.Forms.View.List;
            // 
            // txtCodigoNodo
            // 
            this.txtCodigoNodo.Location = new System.Drawing.Point(106, 99);
            this.txtCodigoNodo.Multiline = true;
            this.txtCodigoNodo.Name = "txtCodigoNodo";
            this.txtCodigoNodo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigoNodo.TabIndex = 5;
            // 
            // txtImporteNodo
            // 
            this.txtImporteNodo.Location = new System.Drawing.Point(106, 161);
            this.txtImporteNodo.Multiline = true;
            this.txtImporteNodo.Name = "txtImporteNodo";
            this.txtImporteNodo.Size = new System.Drawing.Size(100, 25);
            this.txtImporteNodo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 7;
            this.label2.Tag = "Codigo";
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total recaudado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(102, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tengoUnErrorEnMiCodigoToolStripMenuItem,
            this.miImporteNoEsValidoToolStripMenuItem,
            this.nombreInvalidoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // tengoUnErrorEnMiCodigoToolStripMenuItem
            // 
            this.tengoUnErrorEnMiCodigoToolStripMenuItem.Name = "tengoUnErrorEnMiCodigoToolStripMenuItem";
            this.tengoUnErrorEnMiCodigoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.tengoUnErrorEnMiCodigoToolStripMenuItem.Text = "¿Tengo un error en mi codigo?";
            this.tengoUnErrorEnMiCodigoToolStripMenuItem.Click += new System.EventHandler(this.tengoUnErrorEnMiCodigoToolStripMenuItem_Click);
            // 
            // miImporteNoEsValidoToolStripMenuItem
            // 
            this.miImporteNoEsValidoToolStripMenuItem.Name = "miImporteNoEsValidoToolStripMenuItem";
            this.miImporteNoEsValidoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.miImporteNoEsValidoToolStripMenuItem.Text = "¿Mi importe no es valido?";
            this.miImporteNoEsValidoToolStripMenuItem.Click += new System.EventHandler(this.miImporteNoEsValidoToolStripMenuItem_Click);
            // 
            // nombreInvalidoToolStripMenuItem
            // 
            this.nombreInvalidoToolStripMenuItem.Name = "nombreInvalidoToolStripMenuItem";
            this.nombreInvalidoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.nombreInvalidoToolStripMenuItem.Text = "¿Nombre invalido?";
            this.nombreInvalidoToolStripMenuItem.Click += new System.EventHandler(this.nombreInvalidoToolStripMenuItem_Click);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(709, 570);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImporteNodo);
            this.Controls.Add(this.txtCodigoNodo);
            this.Controls.Add(this.lstColaClientes);
            this.Controls.Add(this.txtNombreNodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCobrarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCobrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreNodo;
        private System.Windows.Forms.ListView lstColaClientes;
        private System.Windows.Forms.TextBox txtCodigoNodo;
        private System.Windows.Forms.TextBox txtImporteNodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tengoUnErrorEnMiCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miImporteNoEsValidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreInvalidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
    }
}

