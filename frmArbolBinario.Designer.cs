namespace pryEstructuraDatos
{
    partial class frmArbolBinario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTram = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbArbol = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrdenDescendente = new System.Windows.Forms.RadioButton();
            this.rbInOrdenAscendente = new System.Windows.Forms.RadioButton();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.lstArbol = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblTram);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Location = new System.Drawing.Point(213, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 216);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(109, 114);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTram
            // 
            this.lblTram.AutoSize = true;
            this.lblTram.Location = new System.Drawing.Point(15, 117);
            this.lblTram.Name = "lblTram";
            this.lblTram.Size = new System.Drawing.Size(45, 13);
            this.lblTram.TabIndex = 2;
            this.lblTram.Text = "Tramite:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 75);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(15, 39);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbArbol);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento a eliminar";
            // 
            // cmbArbol
            // 
            this.cmbArbol.FormattingEnabled = true;
            this.cmbArbol.Location = new System.Drawing.Point(79, 55);
            this.cmbArbol.Name = "cmbArbol";
            this.cmbArbol.Size = new System.Drawing.Size(121, 21);
            this.cmbArbol.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(68, 102);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(472, 176);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(252, 40);
            this.btnEquilibrar.TabIndex = 9;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstArbol);
            this.groupBox3.Controls.Add(this.rbPostOrden);
            this.groupBox3.Controls.Add(this.rbPreOrden);
            this.groupBox3.Controls.Add(this.rbInOrdenDescendente);
            this.groupBox3.Controls.Add(this.rbInOrdenAscendente);
            this.groupBox3.Controls.Add(this.dgvArbol);
            this.groupBox3.Location = new System.Drawing.Point(2, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 226);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado del arbol";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(6, 130);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rbPostOrden.TabIndex = 11;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.rbPostOrden_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(6, 107);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rbPreOrden.TabIndex = 11;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbPreOrden_CheckedChanged);
            // 
            // rbInOrdenDescendente
            // 
            this.rbInOrdenDescendente.AutoSize = true;
            this.rbInOrdenDescendente.Location = new System.Drawing.Point(6, 84);
            this.rbInOrdenDescendente.Name = "rbInOrdenDescendente";
            this.rbInOrdenDescendente.Size = new System.Drawing.Size(133, 17);
            this.rbInOrdenDescendente.TabIndex = 11;
            this.rbInOrdenDescendente.TabStop = true;
            this.rbInOrdenDescendente.Text = "In-Orden Descendente";
            this.rbInOrdenDescendente.UseVisualStyleBackColor = true;
            this.rbInOrdenDescendente.CheckedChanged += new System.EventHandler(this.rbInOrdenDescendente_CheckedChanged);
            // 
            // rbInOrdenAscendente
            // 
            this.rbInOrdenAscendente.AutoSize = true;
            this.rbInOrdenAscendente.Location = new System.Drawing.Point(6, 61);
            this.rbInOrdenAscendente.Name = "rbInOrdenAscendente";
            this.rbInOrdenAscendente.Size = new System.Drawing.Size(126, 17);
            this.rbInOrdenAscendente.TabIndex = 11;
            this.rbInOrdenAscendente.TabStop = true;
            this.rbInOrdenAscendente.Text = "In-Orden Ascendente";
            this.rbInOrdenAscendente.UseVisualStyleBackColor = true;
            this.rbInOrdenAscendente.CheckedChanged += new System.EventHandler(this.rbInOrdenAscendente_CheckedChanged);
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2});
            this.dgvArbol.Location = new System.Drawing.Point(184, 19);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.Size = new System.Drawing.Size(486, 186);
            this.dgvArbol.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tramite";
            this.Column2.Name = "Column2";
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(-3, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(210, 204);
            this.tvArbol.TabIndex = 11;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lstArbol
            // 
            this.lstArbol.FormattingEnabled = true;
            this.lstArbol.Location = new System.Drawing.Point(692, 19);
            this.lstArbol.Name = "lstArbol";
            this.lstArbol.Size = new System.Drawing.Size(109, 186);
            this.lstArbol.TabIndex = 20;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 477);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 521);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTram;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbArbol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrdenDescendente;
        private System.Windows.Forms.RadioButton rbInOrdenAscendente;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.ListBox lstArbol;
        private System.Windows.Forms.Button btnVolver;
    }
}