using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioDuenio
    {
        IEnumerable<Duenio> GetAllDuenios();
        Duenio AddDuenio(Duenio duenio);
        Duenio UpdateDuenio(Duenio duenio);
        void DeleteDuenio(int idDuenio);    
        Duenio GetDuenio(int idDuenio);
       
    }


}