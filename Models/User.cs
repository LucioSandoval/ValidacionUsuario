using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [MinLength(4, ErrorMessage = "El Nombre debe tener al menos 4 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo Apellidos es obligatorio.")]
    [MinLength(4, ErrorMessage = "Los Apellidos deben tener al menos 4 caracteres.")]
    public string Apellidos { get; set; }

    [Required(ErrorMessage = "El campo Edad es obligatorio.")]
    [Range(1, int.MaxValue, ErrorMessage = "La Edad debe ser un número positivo.")]
    public int Edad { get; set; }

    [Required(ErrorMessage = "El campo Correo Electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El Correo Electrónico debe tener un formato válido.")]
    public string CorreoElectronico { get; set; }

    [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
    [MinLength(8, ErrorMessage = "La Contraseña debe tener al menos 8 caracteres.")]
    public string Contrasena { get; set; }


    public  User(){}

}
