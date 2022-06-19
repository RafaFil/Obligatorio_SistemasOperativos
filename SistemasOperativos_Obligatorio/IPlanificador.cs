using System;
using System.Collections.Generic;

namespace SistemasOperativos_Obligatorio
{
    public interface IPlanificador : IObservable<PlanificadorBase.Estado>{
        /// <summary>
        /// Inicia la ejecución de los procesos asignados a este planificador.
        /// </summary>
        void Iniciar();

        /// <summary>
        /// Pausa la ejecución de los procesos asignados a este planificador.
        /// </summary>
        void Pausar();

        bool Pausado { get; set; }
        event EventHandler PausadoChanged;
    }
}