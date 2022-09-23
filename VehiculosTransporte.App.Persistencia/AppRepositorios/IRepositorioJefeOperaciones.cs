using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioJefeOperaciones
    {
        IEnumerable<JefeOperaciones> GetAllJefesOperaciones();
        JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeOperaciones);
        JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeOperaciones);
        JefeOperaciones GetJefeOperaciones(int idJefeOperaciones);
        void DeleteJefeOperaciones(int idJefeOperaciones);
    }
}