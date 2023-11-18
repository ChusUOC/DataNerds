using Producto_2.Modelo;
using Producto_2.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Controlador
{
    internal class UtenticacionControlador
    {
        public bool inicioSesion(string nombreUsuario,string password)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
               // string passHash = HashPass(password);
                var usuario = db.Usuario.Where(u => u.nombre == nombreUsuario).FirstOrDefault();
                
                if (usuario != null && usuario.password == password)
                {
                    return true;
                }

                return false; 
            }
        }
        /*
        private string HashPass(string password)
        {
            return Convert.ToBase64String(
            System.Security.Cryptography.SHA256.Create()
            .ComputeHash(Encoding.UTF8.GetBytes(password))
            );
        }
        */

        public void AgregarUsuario(String nombreUsuario, String pass) {
        using(dbHotelSQLEntities db =new dbHotelSQLEntities())
            {
                var usuario = new Usuario
                {
                   nombre = nombreUsuario,
                   password = pass
                };

                db.Usuario.Add(usuario);
                db.SaveChanges();
            }
        }
    }
}
