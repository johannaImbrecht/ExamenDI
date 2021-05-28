using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamenDashboard
{
    public partial class Form1 : Form
    {
        private Panel panelDatos;
        private ControlesUsuario.Grafica grafica;
        private ControlesUsuario.Barras barras;
        public Form1()
        {
            InitializeComponent();
            panelDatos = panelCompleto;
            barras = new ControlesUsuario.Barras();
            grafica = new ControlesUsuario.Grafica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCompleto.Controls.Remove(grafica);
            panelCompleto.Controls.Remove(barras);
            Chart pie = grafica.chart1;
            pie.Series[0].Points.Clear();

            int datos = 50;
            int datos2 = 30;
            pie.Series[0].Points.AddXY("Datos1", datos);
            pie.Series[0].Points.AddXY("Datos2", datos2);
            panelCompleto.Controls.Add(grafica);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCompleto.Controls.Remove(grafica);
            panelCompleto.Controls.Remove(barras);
            Chart bar = barras.chart1;
            bar.Series[0].Points.AddXY("a", 2);
            bar.Series[0].Points.AddXY("b", 3);
            panelCompleto.Controls.Add(bar);
        }
    }
}
