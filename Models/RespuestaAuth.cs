﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comisarias.App.Escritorio.Models
{
   public class RespuestaAuth
    {
        public int FueExitosa { get; set; }
        public string Mensaje { get; set; }
        public ViewModelUserRole modelUserRole { get; set; }
    }
}
