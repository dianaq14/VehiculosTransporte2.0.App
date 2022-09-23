using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioServicioTransporte
    {
        IEnumerable<ServicioTransporte> GetAllServiciosTransporte();
        ServicioTransporte AddServicioTransporte(ServicioTransporte servicioTransporte);
        ServicioTransporte UpdateServicioTransporte(ServicioTransporte servicioTransporte);
        ServicioTransporte GetServicioTransporte(int idServicioTransporte);
        void DeleteServicioTransporte(int idServicioTransporte);
    }
}