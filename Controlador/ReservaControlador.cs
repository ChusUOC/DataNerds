﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;

namespace Producto_2.Controlador
{
    internal class ReservaControlador
    {
        public List<Reservas> ObtenerReserva()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.ToList();
            }
        }
        public List<Reservas> BuscarReserva(int ID)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.Where(c => c.reservaID.Equals(ID)).ToList();
            }
        }
        public void AgregarReserva(Reservas reserva)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.Reservas.Add(reserva);
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
                    throw new Exception("Error al agregar reserva: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.Message);
                }
            }
        }
        public void EliminarReserva(int ID)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var reservaEliminar = db.Reservas.FirstOrDefault(c => c.reservaID == ID);
                    if (reservaEliminar == null)
                    {
                        throw new Exception("Reserva no encontrada. ");
                    }

                    db.Reservas.Remove(reservaEliminar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la reserva: " + ex.Message);
                }
            }
        }
        public void ActualizarReserva(int ID, byte firmado, DateTime fechaEntrada, DateTime fechaSalida, string NIF, int numeroHabitacion, int temporadaID)
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
