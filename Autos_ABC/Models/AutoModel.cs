using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autos_ABC.Models
{
    public class AutoModel
    {
        [Display(Name = "IdAuto")]
        public int IdAuto { get; set; }

        [Required(ErrorMessage = "Marca es requerida.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Modelo requerido.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Folio es requerido.")]
        [RegularExpression(@"^[a-zA-Z]{3}-\d{4}$", ErrorMessage = "El formato de Folio es XXX-0000")]
        public string Folio { get; set; }

        [Required(ErrorMessage = "Color es requerido.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Transmisión es requerido.")]
        public bool Transmision { get; set; }

        [Required(ErrorMessage = "Descripción es requerido.")]
        public string Descripcion { get; set; }

    }
}

