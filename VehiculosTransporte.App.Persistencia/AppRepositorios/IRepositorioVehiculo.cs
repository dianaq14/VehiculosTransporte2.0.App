using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculo ();
        Vehiculo AddVehiculo(Vehiculo vehiculos);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        Vehiculo GetVehiculo(int idVehiculo);
        void DeleteVehiculo(int idVehiculo);
     }
}