﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public interface IObservador<T>
    {
        void Notificar(T notificacion);
    }
}