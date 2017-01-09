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
            try
            {
                List<Respuesta> respuestas = new List<Respuesta>();

                respuestas = context.Respuestas.Where((e) => e.IdPregunta == pregunta.Id).ToList();

                respuestas.Sort((p1, p2) => p1.Descripcion.CompareTo(p2.Descripcion));

                return respuestas;
            } catch (Exception ex) {
                return null;
            }
            
        }
            
        public List<Pregunta> GetPreguntas()
        {
            try
            {
                return context.Preguntas.ToList();
            } catch (Exception ex) //Ros, marron aqui
            {
                return null;
            }
            
        }

    }
}
