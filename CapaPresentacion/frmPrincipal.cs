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
        private Pregunta preg;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void siguientePregunta()
        {
            preg = miNegocio.GetPregunta();
            lblPregunta.Text = preg.Descripción;

            Respuestas respuestas = miNegocio.GetRespuestasFrom(preg);

            //más super hardcodeo
            for (int i = 0; i < respuestas.Correctas.Count; i++)
            {
                gboPreguntas.Controls[i].Text = respuestas.Correctas[i].Descripcion;
            }
            for (int i = 0; i < respuestas.Erroneas.Count; i++)
            {
                gboPreguntas.Controls[i + respuestas.Correctas.Count].Text = respuestas.Erroneas[i].Descripcion;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            miNegocio.GetPreguntas();
            siguientePregunta();

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            siguientePregunta();
        }
    }
}
