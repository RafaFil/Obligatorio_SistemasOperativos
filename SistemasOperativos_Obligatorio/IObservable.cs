﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos_Obligatorio
{
    public interface IObservable<T>
    {
        void Subscribe(IObservador<T> observador);
        void Unsubscribe(IObservador<T> observador);
    }
}