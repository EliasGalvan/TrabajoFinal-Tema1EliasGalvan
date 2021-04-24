using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinal_Tema1POO.BL;
using TrabajoFinal_Tema1POO.BL.Enums;

namespace TrabajoFinal_Tema1POO.Windows
{
    public partial class FrmTrianguloAE : Form
    {
        public FrmTrianguloAE()
        {
            InitializeComponent();
        }
        private Triangulo triangulo;
        private void FrmTrianguloAE_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboBorde(ref BordeComboBox);
            if (triangulo!=null)
            {
                LadoTextBox.Text = triangulo.Lado.ToString();
                BordeComboBox.SelectedItem = triangulo.Borde;
            }
        }

        private void CargarDatosComboBorde(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Borde));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (triangulo == null)
                {
                    triangulo = new Triangulo();

                }
                triangulo.Lado = double.Parse(LadoTextBox.Text);
                triangulo.Borde = (Borde)BordeComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }
        public Triangulo GetTriangulo()
        {
            return triangulo;
        }

        private bool ValidarDatos()
        {
            bool validar = true;
            errorProvider1.Clear();
            if (!double.TryParse(LadoTextBox.Text, out double ladoResultado) || ladoResultado<0)
            {
                 validar = false;
                errorProvider1.SetError(LadoTextBox, "Debe igresar un lado valido");
            }
            return validar;
        }

        public void SetTriangulo(Triangulo triangulo)
        {
            this.triangulo = triangulo;
        }
    }
}
