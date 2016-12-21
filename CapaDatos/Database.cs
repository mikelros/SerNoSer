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
        private Random rdn = new Random();

        public Respuestas GetRespuestasFrom(Pregunta pregunta)
        {
            Respuestas respuestas = new Respuestas();

            respuestas.Erroneas = context.Erroneas.Where((e)=>e.IdPregunta == pregunta.ID).ToList();
            respuestas.Correctas = context.Correctas.Where((e) => e.IdPregunta == pregunta.ID).ToList();

            return respuestas;
        }

        //De momento sacando el numero aleatorio de pregunta
        public int GetNumPreguntas()
        {
            return rdn.Next(1, context.Preguntas.Count());
        }
    }
}
