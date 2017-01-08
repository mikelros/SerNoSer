using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class Database
    {
        private CulturillaEntities context = new CulturillaEntities();

        public List<Respuesta> GetRespuestasFrom(Pregunta pregunta)
        {
            List<Respuesta> respuestas = new List<Respuesta>();

            respuestas = context.Respuestas.Where((e)=>e.IdPregunta == pregunta.Id).ToList();

            respuestas.Sort((p1, p2) => p1.Descripcion.CompareTo(p2.Descripcion));

            return respuestas;
        }
            
        public List<Pregunta> GetPreguntas()
        {
            return context.Preguntas.ToList();
        }

    }
}
