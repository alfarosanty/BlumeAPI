﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public  class RemitoIngreso
    {
        public static String TABLA="INGRESO_STOCK";

        public Taller Taller { get; set; }

        public DateTime fecha { get; set; }

        public string Descripcion { get; set; }

        public List<ArticuloIngreso> Articulos { get; set; }

    
    }


