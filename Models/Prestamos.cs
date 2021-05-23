using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registro1_Ap2.Models
{
 public class Prestamos{
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        
        public int PersonaId { get; set; } 
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public string Concepto { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public decimal Balance { get; set; }
       
       [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }
    }
}