using System;

namespace CapaEntidad
{
    public class Agenda
    {
        public int Id_Agenda { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_de_nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
        public string Estado_civil { get; set; } //(Soltero/a, casado/a, divorciado/a, viudo/a)
        public string Movil { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
    }
}
