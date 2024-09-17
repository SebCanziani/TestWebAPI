﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public Producto(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        [Range(1, int.MaxValue, ErrorMessage = "El Id debe ser un número mayor que cero.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El Precio debe ser un número mayor que cero.")]
        public int Price { get; set; }
    }

}
