using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double V1 = Convert.ToDouble(textBox1.Text);
            Double V2 = Double.Parse(textBox2.Text);

            Calculadora calc = new Calculadora(V1, V2);
            Double resultado = calc.Calcular((Calculadora.Operacao)comboBoxOperacao.SelectedItem);

            label4.Text = "Resultado: " + resultado.ToString("N2");
        }
    }
}
