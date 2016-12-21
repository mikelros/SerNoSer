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
        private List<Pregunta> preguntas;

        public Respuestas GetRespuestasFrom(Pregunta pregunta)
        {
            Respuestas respuestas = new Respuestas();

            respuestas.Erroneas = context.Erroneas.Where((e)=>e.IdPregunta == pregunta.ID).ToList();
            respuestas.Correctas = context.Correctas.Where((e) => e.IdPregunta == pregunta.ID).ToList();

            return respuestas;
        }
            
        //Recuperamos todas las preguntas
        public void GetPreguntas()
        {
            preguntas = (from p in context.Preguntas
                         select p).ToList();
        }

        //Seleccionamos una pregunta aleatoria de nuestra lista y la eliminamos
        public Pregunta GetPregunta()
        {
            if (preguntas.Count() == 0)
            {
                int num = rdn.Next(1, preguntas.Count());
                Pregunta preg = preguntas[num];

                preguntas.RemoveAt(num);
                return preg;
            }

            return null;
        }
    }
}
