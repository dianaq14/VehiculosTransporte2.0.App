using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
 public class RepositorioVehiculo : IRepositorioVehiculo
 {
    ///<summary>
        ///Referencia al contexto de JefeOperaciones
        ///</summary>
        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo constructor 
        ///Inyeccion depencias para indicar el contexto a usar
        ///</summary>
        ///<param name="appContext"></param>//


        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }
        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
        {
            var VehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return VehiculoAdicionado.Entity;
        }
        IEnumerable<Vehiculo>  IRepositorioVehiculo.GetAllVehiculo()
        {
            return _appContext.Vehiculos;
        }

        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Id == vehiculo.Id);
            if (VehiculoEncontrado != null)
            {
                 VehiculoEncontrado.Id=vehiculo.Id;
                 VehiculoEncontrado.placa=vehiculo.placa;
                 VehiculoEncontrado.marca=vehiculo.marca;
                 VehiculoEncontrado.modelo_año=vehiculo.modelo_año;
                 VehiculoEncontrado.tipo=vehiculo.tipo;
                 VehiculoEncontrado.CapacidadPasajeros=vehiculo.CapacidadPasajeros;
                 VehiculoEncontrado.Duenio=vehiculo.Duenio;
                 VehiculoEncontrado.Mecanico=vehiculo.Mecanico;
                 VehiculoEncontrado.Conductor=vehiculo.Conductor;
                 VehiculoEncontrado.Soat=vehiculo.Soat;
                 VehiculoEncontrado.SeguroContractual=vehiculo.SeguroContractual;
                 VehiculoEncontrado.SeguroExtracontractual=vehiculo.SeguroExtracontractual;
                 VehiculoEncontrado.RevisionTecnicoMecanica=vehiculo.RevisionTecnicoMecanica;
               

                _appContext.SaveChanges();
            }
            return VehiculoEncontrado;
        }
        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(v => v.Id == idVehiculo);
        }
        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(v => v.Id == idVehiculo);
            if (VehiculoEncontrado == null)
                return;
            _appContext.Vehiculos.Remove(VehiculoEncontrado);
            _appContext.SaveChanges();
        }
    }

}

