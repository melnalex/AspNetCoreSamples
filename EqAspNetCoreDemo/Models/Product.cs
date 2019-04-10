﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Korzh.EasyQuery;

namespace EqAspNetCoreDemo.Models
{
    [DisplayColumn("Name")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ProductID")]
        public int Id { get; set; }

        public string Name { get; set; }


        [ScaffoldColumn(false)]
        public int? SupplierId { get; set; }

        public string EnglishName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }


}