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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //super hardcoded
            Pregunta preg = new Pregunta();
            preg.ID = 1;
            Respuestas respuestas = miNegocio.GetRespuestasFrom(preg);

            for (int i = 0; i < respuestas.Correctas.Count; i++)
            {
                gboPreguntas.Controls[i].Text = respuestas.Correctas[i].Descripcion;
            }

            for (int i = 0; i < respuestas.Erroneas.Count; i++)
            {
                gboPreguntas.Controls[i + respuestas.Correctas.Count].Text = respuestas.Erroneas[i].Descripcion;
            }

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
