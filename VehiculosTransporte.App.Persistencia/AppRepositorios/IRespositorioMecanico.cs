using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public interface IRepositorioMecanico
    {
        IEnumerable<Mecanico> GetAllMecanicos();
        Mecanico GetMecanico(int idMecanico);
        Mecanico  AddMecanico (Mecanico mecanico);
        Mecanico UpdateMecanico (Mecanico mecanico);
        void DeleteMecanico(int idMecanico);
    }
}