using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticasPOO
{
    public class AvisosTrafico : IAvisos
    {

        public AvisosTrafico() 
        {
            remitente = "DTG";
            mensaje = "Aviso de infracción. Page cuanto antes su deuda DE TRAFICO para adquirir un descuento.";
            fecha = DateTime.Now;
        }

        public AvisosTrafico(string remitente, string mensaje, DateTime fecha)
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
