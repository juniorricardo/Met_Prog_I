﻿using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;
using MetProgI.Patron_Proxy;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaAlumnoProxy : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            Generar random = new Generar();
            return new AlumnoProxy(random.Gen_Nombre(), random.Gen_DNI(), random.Gen_DNI(), random.Gen_Promedio() );
        }

        public I_Comparable crearPorTeclado()
        {
            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Documento: ");
            string documento = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Legajo: ");
            string legajo = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Promedio: ");
            string promedio = Console.ReadLine();

            return new AlumnoProxy(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
        }
    }
}
