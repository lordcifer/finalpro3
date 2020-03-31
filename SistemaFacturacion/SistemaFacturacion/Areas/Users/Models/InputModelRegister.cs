using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "La cedula es obligatorio")]
        public string NID { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([\+]?[0-9]{1,3}[\s.-][0-9]{1,12})([\s.-]?[0-9]{1,4}?)$", ErrorMessage = "<font color='red'>El formato ingresado es invalido.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electronico no es un correo electronico valido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
