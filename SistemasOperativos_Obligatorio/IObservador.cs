using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public interface IObservador<T>
    {
        /// <summary>
        /// Envia una notificación a este observador.
        /// </summary>
        /// <param name="notificacion">los datos que el observador espera recibir del IObservable</param>
        void Notificar(T notificacion);
    }
}
