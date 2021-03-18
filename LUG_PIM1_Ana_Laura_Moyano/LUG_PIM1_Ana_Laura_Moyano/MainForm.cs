using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace LUG_PIM1_Ana_Laura_Moyano
{
    public partial class MainForm : Form
    {

        private const string NOMBRE_ARCHIVO = "simon.xml";

        private Simon simon;

        public MainForm()
        {
            InitializeComponent();
            InicializarDatos();
            RefrescarGrilla();
        }

        private void InicializarDatos()
        {
            try
            {
                simon = ArchivoSimon.LeerArchivo(NOMBRE_ARCHIVO);
                simon.Juego++;
            }
            catch
            {
                simon = new Simon();
                simon.Juego = 1;
                MessageBox.Show("No se pudo leer el archivo. Iniciando Juego.");
            }
        }

        private void GuardarSimon()
        {
            ArchivoSimon.GuardarArchivo(NOMBRE_ARCHIVO, simon);
        }

        private void AgregarSecuencia()
        {
            simon.AgregarSecuencia(CreadorSecuencia.GenerarSecuencia());
        }

        private void btnAgregarSecuencia_Click(object sender, EventArgs e)
        {
            AgregarSecuencia();
            GuardarSimon();
            MessageBox.Show("Secuencia Actualizada");
            RefrescarGrilla();
        }

        private string ValorColor(int valor)
        {
            switch (valor)
            {
                case 1:
                    return "Rojo";
                case 2:
                    return "Verde";
                case 3:
                    return "Amarillo";
                case 4:
                    return "Azul";
                default:
                    return "N/A";
            }
        }

        private void RefrescarGrilla()
        {
            grvSecuencia.DataSource = simon.Secuencias.Select(TransformarDatos).ToList();
            grvSecuencia.Refresh();
        }

        private dynamic TransformarDatos(Secuencia secuencia)
        {
            int anterior = secuencia.Anterior - 1;
            int posterior = secuencia.Posterior - 1;
            return new
            {
                ID = secuencia.Id,
                VALOR = ValorColor(secuencia.Valor),
                ANTERIOR = ValorColor(anterior >= 0 ? simon.Secuencias[anterior].Valor : 0),
                POSTERIOR = ValorColor(posterior >= 0 ? simon.Secuencias[posterior].Valor : 0),
            };
        }
    }
}
