using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public interface IObservable<T>
    {
        /// <summary>
        /// Registra un observador para recibir notificaciones de este IObservable.
        /// </summary>
        /// <param name="observador">el IObservador que recibirá las notificaciones</param>
        void VerComoMueveLaCola(IObservador<T> observador);

        /// <summary>
        /// Elimina un observador de la lista de observadores de este IObservable.
        /// </summary>
        /// <param name="observador">el IObservador a eliminar de la lista de observadores</param>
        void SalirCorriendoAlVerSuPistola(IObservador<T> observador);
    }
}
