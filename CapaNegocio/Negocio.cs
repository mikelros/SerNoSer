using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class Negocio
    {
        private Database misDatos = new Database();

        public List<Respuesta> GetRespuestasFrom(Pregunta pregunta)
        {
            return misDatos.GetRespuestasFrom(pregunta);
        }

        public List<Pregunta> GetPreguntas()
        {
            return misDatos.GetPreguntas();
        }
        
    }
}
