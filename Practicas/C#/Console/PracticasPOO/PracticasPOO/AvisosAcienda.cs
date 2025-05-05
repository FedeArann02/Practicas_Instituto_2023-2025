using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPOO
{
    public class AvisosAcienda : IAvisos
    {
        public AvisosAcienda()
        {
            remitente = "DTG";
            mensaje = "Aviso de infracción. Page cuanto antes su deuda DE ACIENDA para adquirir un descuento.";
            fecha = DateTime.Now;
        }

        public AvisosAcienda(string remitente, string mensaje, DateTime fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje: {0} ha sido enviado por {1} la fecha {2}", mensaje, remitente, fecha);
        }

        private string remitente;

        private string mensaje;

        private DateTime fecha;
    }
}
