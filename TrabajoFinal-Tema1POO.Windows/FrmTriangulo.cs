using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabajoFinal_Tema1POO.BL;
using TrabajoFinal_Tema1POO.Datos;

namespace TrabajoFinal_Tema1POO.Windows
{
    public partial class FrmTriangulo : Form
    {
        public FrmTriangulo()
        {
            InitializeComponent();
        }
        
        public RepositorioTriangulo _repositorio;
        private List<Triangulo> _lista;
        

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FrmTrianguloAE frm = new FrmTrianguloAE();
            frm.Text = "Agregar lado del Triangulo Equilatero";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    Triangulo triangulo = frm.GetTriangulo();
                    _repositorio.Agregar(triangulo);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, triangulo);
                    AgregarFila(r);
                    MessageBox.Show("Datos guardados", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void FrmTriangulo_Load(object sender, EventArgs e)
        {
            _repositorio = new RepositorioTriangulo();
            try
            {
                
                _lista = _repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Triangulo triangulo)
        {
            r.Cells[colLado.Index].Value = triangulo.Lado;
            r.Cells[colPerimetro.Index].Value = triangulo.GetPerimetro();
            r.Cells[colSupericie.Index].Value = triangulo.GetSuperficie();
            r.Cells[colBorde.Index].Value = triangulo.Borde;
            r.Tag = triangulo;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var triangulo in _lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, triangulo);
                AgregarFila(r);
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0] ;
            Triangulo triangulo = (Triangulo)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar {triangulo.Lado}?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            else
                try
                {
                    _repositorio.Borrar(triangulo);
                    DatosDataGridView.Rows.Remove(r);
                    MessageBox.Show("Registro borrado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.Rows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Triangulo triangulo = (Triangulo)r.Tag;
            Triangulo trianguloCopia = (Triangulo)triangulo.Clone();
            FrmTrianguloAE frm = new FrmTrianguloAE();
            frm.Text = "Editar Triangulo";
            frm.SetTriangulo(triangulo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                triangulo = frm.GetTriangulo();
                _repositorio.Editar(triangulo, trianguloCopia);
                SetearFila(r,triangulo);
                MessageBox.Show("Registro editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AcrualizarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                _lista = _repositorio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }

        }

        private void porLadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.OrdenarLado();
            MostrarDatosEnGrilla();
            
        }

        private void porBordeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lista = _repositorio.OrdenarBorde();
            MostrarDatosEnGrilla();
        }
    }
}
