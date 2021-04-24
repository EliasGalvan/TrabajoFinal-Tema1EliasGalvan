
namespace TrabajoFinal_Tema1POO.Windows
{
    partial class FrmTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTriangulo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.AcrualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.porLadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porBordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colLado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupericie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoButton,
            this.EditarToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripSeparator1,
            this.SalirToolStripButton,
            this.AcrualizarToolStripButton,
            this.OrdenarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.Control;
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(46, 59);
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLado,
            this.colPerimetro,
            this.colSupericie,
            this.colBorde});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 62);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.Size = new System.Drawing.Size(606, 302);
            this.DatosDataGridView.TabIndex = 1;
            // 
            // AcrualizarToolStripButton
            // 
            this.AcrualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AcrualizarToolStripButton.Image")));
            this.AcrualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AcrualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AcrualizarToolStripButton.Name = "AcrualizarToolStripButton";
            this.AcrualizarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.AcrualizarToolStripButton.Text = "Actualizar";
            this.AcrualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AcrualizarToolStripButton.Click += new System.EventHandler(this.AcrualizarToolStripButton_Click);
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porLadoToolStripMenuItem,
            this.porBordeToolStripMenuItem});
            this.OrdenarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarToolStripButton.Image")));
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // porLadoToolStripMenuItem
            // 
            this.porLadoToolStripMenuItem.Name = "porLadoToolStripMenuItem";
            this.porLadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porLadoToolStripMenuItem.Text = "Por Lado";
            this.porLadoToolStripMenuItem.Click += new System.EventHandler(this.porLadoToolStripMenuItem_Click);
            // 
            // porBordeToolStripMenuItem
            // 
            this.porBordeToolStripMenuItem.Name = "porBordeToolStripMenuItem";
            this.porBordeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porBordeToolStripMenuItem.Text = "Por Borde";
            this.porBordeToolStripMenuItem.Click += new System.EventHandler(this.porBordeToolStripMenuItem_Click);
            // 
            // colLado
            // 
            this.colLado.HeaderText = "Lado";
            this.colLado.Name = "colLado";
            this.colLado.ReadOnly = true;
            this.colLado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPerimetro
            // 
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            this.colPerimetro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSupericie
            // 
            this.colSupericie.HeaderText = "Superficie";
            this.colSupericie.Name = "colSupericie";
            this.colSupericie.ReadOnly = true;
            this.colSupericie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            this.colBorde.HeaderText = "Borde";
            this.colBorde.Name = "colBorde";
            this.colBorde.ReadOnly = true;
            this.colBorde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 364);
            this.ControlBox = false;
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(622, 403);
            this.MinimumSize = new System.Drawing.Size(622, 403);
            this.Name = "FrmTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIANGULOS EQUILATEROS";
            this.Load += new System.EventHandler(this.FrmTriangulo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ToolStripButton AcrualizarToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem porLadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porBordeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupericie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorde;
    }
}

