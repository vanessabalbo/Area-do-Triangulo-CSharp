using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis para armazenar os valores do cálculo:
            double b, h = 0;
            double area;
            b = double.Parse(txtBase.Text);
            h = double.Parse(txtAltura.Text);

            area = (b * h) / 2;

            // Aplicação de comando para definir casas decimais:
            lblArea.Text = Math.Round(area, 2).ToString();
        }
        
    }
}
