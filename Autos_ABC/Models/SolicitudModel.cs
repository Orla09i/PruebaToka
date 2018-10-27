using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autos_ABC.Models
{
    public class SolicitudModel
    {
        [Display(Name = "IdSolicitud")]
        public int IdSolicitud { get; set; }

        [Required(ErrorMessage = "Fecha es requerida.")]
        [RegularExpression(@"\d{2}/\d{2}/\d{4}$", ErrorMessage = "El formato de placas es 00/00/0000")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "Número de lote requerido.")]
        [RegularExpression(@"\d{5}$", ErrorMessage = "El formato de Número de lote es 00000")]
        public string NumeroLote { get; set; }

        [Required(ErrorMessage = "Auto requerido.")]
        public int Auto { get; set; }

        [Display(Name = "Folio Auto")]
        public string FolioAuto { get; set; }


        [Display(Name = "Marca Auto")]
        public string MarcaAuto { get; set; }

        [Display(Name = "Modelo Auto")]
        public string ModeloAuto { get; set; }





    }
}