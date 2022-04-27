﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAPPYWeb.model
{
    [Table("TBOficial")]
    public partial class Tboficial
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string Nome { get; set; }
        [Required]
        [Column("CPF")]
        [StringLength(11)]
        [Unicode(false)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(25)]
        [Unicode(false)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(25)]
        [Unicode(false)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Cidade { get; set; }
        [Required]
        [Column("CEP")]
        [StringLength(8)]
        [Unicode(false)]
        public string Cep { get; set; }
        [Required]
        [StringLength(11)]
        [Unicode(false)]
        public string Telefone { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Cargo { get; set; }
    }
}