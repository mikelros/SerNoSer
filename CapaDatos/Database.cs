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

        public List<Respuesta> GetRespuestasFrom(Pregunta pregunta)
        {
            List<Respuesta> respuestas = new List<Respuesta>();

            respuestas = context.Respuestas.Where((e)=>e.IdPregunta == pregunta.Id).ToList();

            respuestas.Sort((p1, p2) => p1.Descripcion.CompareTo(p2.Descripcion));

            return respuestas;
        }
            
        //Recuperamos todas las preguntas
        public void GetPreguntas()
        {
            preguntas = context.Preguntas.ToList();
        }

        //Seleccionamos una pregunta aleatoria de nuestra lista y la eliminamos
        public Pregunta GetPregunta()
        {
            if (preguntas.Count() != 0)
            {
                int num = rdn.Next(0, preguntas.Count());
                Pregunta preg = preguntas[num];

                preguntas.RemoveAt(num);
                return preg;
            }

            return null;
        }
    }
}
