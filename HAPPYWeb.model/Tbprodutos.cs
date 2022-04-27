﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HAPPYWeb.model
{
    [Table("TBProdutos")]
    public partial class Tbprodutos
    {
        [Key]
        [Display(Name = "Código do produto")]
        public int Id { get; set; }


        [Display(Name = "")] // Vazio pq coloquei o nome em cada página.
        public int IdMarca { get; set; }


        [Required(ErrorMessage = "Informe o nome do produto")]
        [StringLength(50)]
        [Unicode(false)]
        [Display(Name = "Produto")]
        public string Descricao { get; set; }


        [Required(ErrorMessage = "Informe as unidades")]
        [StringLength(10)]
        [Unicode(false)]
        public string Unidade { get; set; }


        public byte[] Foto { get; set; }


        [Display(Name = "Preço")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.00}")]
        [Required(ErrorMessage = "Valor inválido")]
        public double Preco { get; set; }


        [ForeignKey(nameof(IdMarca))]
        [InverseProperty(nameof(Tbmarca.Tbprodutos))]
        [Display(Name = "Marca")]
        public virtual Tbmarca IdMarcaNavigation { get; set; }
    }
}