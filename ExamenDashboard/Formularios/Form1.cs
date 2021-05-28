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
        private ControlesUsuario.Tablas tablas;
        public Form1()
        {
            InitializeComponent();
            panelDatos = panelCompleto;
            barras = new ControlesUsuario.Barras();
            grafica = new ControlesUsuario.Grafica();
            tablas = new ControlesUsuario.Tablas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
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
            reset();
            Chart bar = barras.chart1;
            bar.Series[0].Points.Clear();
            bar.Series[0].Points.AddXY("a", 2);
            bar.Series[0].Points.AddXY("b", 3);
            bar.Series[0].Points.AddXY("c", 12);
            bar.Series[0].Points.AddXY("d", 13);
            panelCompleto.Controls.Add(barras);
        }

        private void reset()
        {
            panelCompleto.Controls.Remove(grafica);
            panelCompleto.Controls.Remove(barras);
        }

        private void datosEntablas()
        {
            reset();
            DataGridView dtTablas = tablas.datosTabla;

        }
    }
}
