using System;
using System.Collections.Generic;
using System.Text;

namespace App.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Product
{
    [Key]
    public int Amigo { get; set; }

    [Required]
    [Display(Name = "Nombre y Apellido")]
    public string Name { get; set; }

    public int Telefono { get; set; }
}
}