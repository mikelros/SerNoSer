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
        private List<Pregunta> preguntas;
        private int puntos, fallos, aciertos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.btn1.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn2.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn3.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn4.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn5.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn6.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn7.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn8.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn9.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn10.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn11.Click += new System.EventHandler(this.comprobarRespuesta);
            this.btn12.Click += new System.EventHandler(this.comprobarRespuesta);

            fallos = 0;
            puntos = 0;

            preguntas = miNegocio.GetPreguntas();
            cargarPregunta();

        }

        private void cargarPregunta()
        {
            lblError.Text = "";
            Pregunta preg = null;
            if (preguntas.Count() != 0)
            {
                Random rdn = new Random();
                int num = rdn.Next(0, preguntas.Count());
                preg = preguntas[num];

                preguntas.RemoveAt(num);

                lblPregunta.Text = preg.Descripcion;

                List<Respuesta> respuestas = miNegocio.GetRespuestasFrom(preg);

                if (respuestas.Count != 0)
                {
                    for (int i = 0; i < respuestas.Count; i++)
                    {
                        gboPreguntas.Controls[i].Tag = respuestas[i];
                        gboPreguntas.Controls[i].Text = respuestas[i].Descripcion;
                        gboPreguntas.Controls[i].BackColor = Color.LightGray;
                    }
                } else
                {
                    for (int i = 0; i < gboPreguntas.Controls.Count; i++)
                    {
                        gboPreguntas.Controls[i].Enabled = true;
                        gboPreguntas.Controls[i].Text = "";
                        gboPreguntas.Controls[i].Tag = null;
                        gboPreguntas.Controls[i].BackColor = Color.LightGray;
                    }
                }
                
            } else
            {
                MessageBox.Show("Ya no hay más preguntas.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comprobarRespuesta(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Respuesta resp = btn.Tag as Respuesta;

            if (resp != null)
            {
                if (resp.esCorrecta()) {
                    acierta(btn);
                } else {
                    falla(btn);
                }

                btn.Enabled = false;
                lblPuntos.Text = puntos.ToString();

            }
        }

        private void falla(Button btn)
        {
            btn.BackColor = Color.Red;
            fallos++;
            puntos /= 2;
            Respuesta resp = btn.Tag as Respuesta;
            lblError.Text = resp.Explicacion;
            if (fallos == 4)
            {
                MessageBox.Show("Ya has fallado todas las posibles respuestas erróneas.", "Lo siento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarPregunta();
            }

        }

        private void acierta(Button btn)
        {
            btn.BackColor = Color.Green;
            aciertos++;
            puntos = puntos == 0 ? 5 : puntos * 2;
            lblError.Text = "";
            if (aciertos == 8)
            {
                MessageBox.Show("Ya has acertado todas las respuestas.", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarPregunta();
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPasar_Click(object sender, EventArgs e)
        {
            cargarPregunta();
        }
    }
}
