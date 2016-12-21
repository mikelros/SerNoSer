using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private static Negocio miNegocio = new Negocio();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaPregunta()
        {
            Pregunta preg = miNegocio.GetPregunta();

            //Temporal para pruebas
            lblPregunta.Text = preg.Descripcion;

            List<Respuesta> respuestas = miNegocio.GetRespuestasFrom(preg);

            for (int i = 0; i < respuestas.Count; i++)
            {
                gboPreguntas.Controls[i].Text = respuestas[i].Descripcion;
                gboPreguntas.Controls[i].BackColor = Color.LightGray;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            miNegocio.GetPreguntas();
            nuevaPregunta();

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            nuevaPregunta();
        }
    }
}
