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

        public Respuestas GetRespuestasFrom(Pregunta pregunta)
        {
            Respuestas respuestas = new Respuestas();

            respuestas.Erroneas = context.Erroneas.Where((e)=>e.IdPregunta == pregunta.ID).ToList();
            respuestas.Correctas = context.Correctas.Where((e) => e.IdPregunta == pregunta.ID).ToList();

            return respuestas;
        }
    }
}
