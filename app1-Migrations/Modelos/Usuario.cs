﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app1_Migrations.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Usuario { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Clave { get; set; }
        [Required]

        public Boolean Estado { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }
    }
}
