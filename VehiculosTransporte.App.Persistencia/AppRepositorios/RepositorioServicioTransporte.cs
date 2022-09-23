using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{

    public class RepositorioServicioTransporte : IRepositorioServicioTransporte
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


        public RepositorioServicioTransporte(AppContext appContext)
        {
            _appContext = appContext;
        }
        ServicioTransporte IRepositorioServicioTransporte.AddServicioTransporte(ServicioTransporte servicioTransporte)
        {
            var ServicioTransporteAdicionado = _appContext.ServiciosTransporte.Add(servicioTransporte);
            _appContext.SaveChanges();
            return ServicioTransporteAdicionado.Entity;
        }
        IEnumerable<ServicioTransporte>  IRepositorioServicioTransporte.GetAllServiciosTransporte()
        {
            return _appContext.ServiciosTransporte;
        }

        ServicioTransporte IRepositorioServicioTransporte.UpdateServicioTransporte(ServicioTransporte servicioTransporte)
        {
            var ServicioTransporteEncontrado = _appContext.ServiciosTransporte.FirstOrDefault(s => s.Id == servicioTransporte.Id);
            if (ServicioTransporteEncontrado != null)
            {
                ServicioTransporteEncontrado.FechaServicio= servicioTransporte.FechaServicio;
                ServicioTransporteEncontrado.Recorrido= servicioTransporte.Recorrido;
                ServicioTransporteEncontrado.Vehiculo= servicioTransporte.Vehiculo;
                ServicioTransporteEncontrado.TipoServicio= servicioTransporte.TipoServicio;
                ServicioTransporteEncontrado.ValorServicio= servicioTransporte.ValorServicio;
                ServicioTransporteEncontrado.Cliente= servicioTransporte.Cliente;

                _appContext.SaveChanges();
            }
            return ServicioTransporteEncontrado;
        }
        ServicioTransporte IRepositorioServicioTransporte.GetServicioTransporte(int idServicioTransporte)
        {
            return _appContext.ServiciosTransporte.FirstOrDefault(s => s.Id == idServicioTransporte);
        }
        void IRepositorioServicioTransporte.DeleteServicioTransporte(int idServicioTransporte)
        {
            var ServicioTransporteEncontrado = _appContext.ServiciosTransporte.FirstOrDefault(s => s.Id == idServicioTransporte);
            if (ServicioTransporteEncontrado == null)
                return;
            _appContext.ServiciosTransporte.Remove(ServicioTransporteEncontrado);
            _appContext.SaveChanges();
        }
    }


}