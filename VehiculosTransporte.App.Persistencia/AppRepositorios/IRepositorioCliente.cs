using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{

    public interface IRespositorioCliente
    {
        IEnumerable<Cliente> GetallClientes();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int IdCliente);
        Cliente GetCliente(int IdCliente);

    }
}