﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDataGrid.Model
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }

        public Estudiante(string name, int age, string email)
        {
            Nombre = name;
            Edad = age;
            Email = email;
        }
    }
}
