using System;

namespace InventarioTI.Models.EXT_WEB
{
    public class RH00_Usuarios
    {
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public int Escolaridad { get; set; }
        public string NssCpts { get; set; }
        public string RfcCpf { get; set; }
        public string CurpRg { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int? Hijos { get; set; }
        public int? NumeroEmpleado { get; set; }
        public string TelefonoPersonal { get; set; }
        public string TelefonoAsignado { get; set; }
        public string CorreoPersonal { get; set; }
        public string CorreoEmpresa { get; set; }
        public string Expatriado { get; set; }
        public int? TallaPlayera { get; set; }
        public int? TallaPantalon { get; set; }
        public int? TallaCalzado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string MedioReclutamiento { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CausaBaja { get; set; }
        public bool? LoginCorreoPersonal { get; set; }
        public string Contrasenia { get; set; }
        public bool? ControlAsistencia { get; set; }
        public bool EsJefe { get; set; }
        public bool? IntermitirTurno { get; set; }
        public int? HorasExtrasAceptadas { get; set; }
        public string ObservacionesBaja { get; set; }
    }
}
