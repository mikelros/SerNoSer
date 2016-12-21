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

        public Respuestas GetRespuestasFrom(Pregunta pregunta)
        {
            return misDatos.GetRespuestasFrom(pregunta);
        }
        
    }
}
