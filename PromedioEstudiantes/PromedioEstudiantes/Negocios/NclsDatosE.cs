﻿using PromedioEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioEstudiantes.Negocios
{
    class NclsDatosE
    {
        public string Calculos(ClsEstudiante datos) 
        {
            datos.Periodo1 = datos.Lab1 * 0.40 + datos.Parcial1 * 0.60;
            datos.Periodo2 = datos.Lab2 * 0.40 + datos.Parcial2 * 0.60;
            datos.Periodo3 = datos.Lab3 * 0.40 + datos.Parcial3 * 0.60;
            datos.NotaFinal = (datos.Periodo1 + datos.Periodo1 + datos.Periodo1) / 3;
            datos.NotaFinal = Convert.ToDouble(datos.NotaFinal);

            return "\nPeriodo1: " + datos.Periodo1 + " \nPeriodo2: " + datos.Periodo2 + "\nPeriodo3: " + datos.Periodo2;
        }
    }
}
