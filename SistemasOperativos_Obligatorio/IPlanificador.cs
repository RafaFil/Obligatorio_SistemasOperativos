using System;
using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public interface IPlanificador : IObservable<PlanificadorBase.Estado>{
        /// <summary>
        /// Inicia la ejecuci�n de los procesos asignados a este planificador.
        /// </summary>
        void Iniciar();

        /// <summary>
        /// Pausa la ejecuci�n de los procesos asignados a este planificador.
        /// </summary>
        void Pausar();

        bool Pausado { get; set; }
        event EventHandler PausadoChanged;
    }
}