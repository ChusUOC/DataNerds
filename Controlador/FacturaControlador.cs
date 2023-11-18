using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;
using Producto_2.Vista;

namespace Producto_2.Controlador
{
    internal class FacturaControlador
    {
        

        public List<Factura> ObtenerFactura()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Factura.ToList();
            }
        }
        public List<Factura> BuscarFactura(int numeroFactura)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Factura.Where(c => c.numeroFactura.Equals(numeroFactura)).ToList();
            }
        }
        public void AgregarFactura(Factura factura)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.Factura.Add(factura);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            sb.AppendLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw new Exception(sb.ToString());
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception("Error al agregar factura: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar factura: " + ex.Message);
                }
            }
        }
        public void EliminarFactura(int numeroFactura)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var facturaEliminar = db.Factura.FirstOrDefault(c => c.numeroFactura == numeroFactura);
                    if (facturaEliminar == null)
                    {
                        throw new Exception("Factura no encontrada. ");
                    }

                    db.Factura.Remove(facturaEliminar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la factura: " + ex.Message);
                }
            }
        }
        public void ActualizarFactura(int ID, byte firmado, DateTime fechaEntrada, DateTime fechaSalida, string NIF, int numeroHabitacion, int temporadaID)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var reservaActualizar = db.Reservas.FirstOrDefault(c => c.reservaID == ID);
                    if (reservaActualizar == null)
                    {
                        throw new Exception("Reserva no encontrado. ");
                    }
                    reservaActualizar.reservaID = ID;
                    reservaActualizar.firmado = firmado;
                    reservaActualizar.fechaEntrada = fechaEntrada;
                    reservaActualizar.fechaSalida = fechaSalida;
                    reservaActualizar.NIF = NIF;
                    reservaActualizar.numeroHabitacion = numeroHabitacion;
                    reservaActualizar.temporadaID = temporadaID;

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar la reserva: " + ex.Message);
                }
            }
        }
    }

}