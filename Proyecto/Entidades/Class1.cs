namespace Entidades
{
    public class login
    {
        public string contraseña { get; set; }

        public string rol { get; set; }

        public string codigousuario { get; set; }

        public DateTime Myproperty { get; set; }


        public login()
        {
        }

        public login(string contraseña, string rol, string usuario)
        {
            this.contraseña = contraseña;
            this.rol = rol;
            this.codigousuario = usuario;
        }
    }
}