using System;

namespace CapaEntidades
{
    public class Usuario
    {
        
        public int Id_Usuario;
        public String Correo_Electronico;
        public String Password;
        public DateTime Fecha_Creacion;
        public Boolean Activo;
        public int Codigo_Rol;
        
        public Usuario() : this(1,"","",DateTime.Now, true,1) { }
        
        public Usuario(int Id_Usuario, string Correo_Electronico, string Password, DateTime Fecha_Creacion, bool Activo, int Codigo_Rol)
        {
            Id_Usuario = Id_Usuario;
            Correo_Electronico = Correo_Electronico;
            Password = Password;
            Fecha_Creacion = Fecha_Creacion;
            Activo = Activo;
            Codigo_Rol = Codigo_Rol;
        }
    }
}