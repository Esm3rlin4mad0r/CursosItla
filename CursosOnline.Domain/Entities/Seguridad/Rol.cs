using System;

namespace CursosOnline.Domain.Entities.Seguridad
{
    public partial class Rol : Core.BaseEntity
    {

        public int Id { get; set; }
        public string? Descripcion { get; set; }

    }
}