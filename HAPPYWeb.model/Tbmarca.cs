﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAPPYWeb.model
{
    [Table("TBMarca")]
    public partial class Tbmarca
    {
        public Tbmarca()
        {
            Tbprodutos = new HashSet<Tbprodutos>();
        }

        [Key]
        [Display(Name = "Código da marca")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        [Display(Name = "Marca")]
        public string Descricao { get; set; }

        [InverseProperty("IdMarcaNavigation")]   
        public virtual ICollection<Tbprodutos> Tbprodutos { get; set; }
    }
}