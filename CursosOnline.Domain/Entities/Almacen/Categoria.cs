﻿//using System.ComponentModel.DataAnnotations.Schema;
namespace CursosOnline.Domain.Entities.Almacen
{
   
    public partial class Categoria : Core.BaseEntity
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }

    }
}