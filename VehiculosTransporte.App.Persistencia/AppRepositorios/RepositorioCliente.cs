using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Persistencia
{
    public class RespositorioCliente : IRespositorioCliente
    {
        private readonly AppContext _appContext;
        public RespositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }

        Cliente IRespositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }


        void IRespositorioCliente.DeleteCliente(int IdCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == IdCliente);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Cliente> IRespositorioCliente.GetallClientes()
        {
            return _appContext.Clientes;
        }

        Cliente IRespositorioCliente.GetCliente(int IdCliente)
        {
            return _appContext.Clientes.FirstOrDefault(p => p.Id == IdCliente);
        }

        Cliente IRespositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.Nombres = cliente.Nombres;
                clienteEncontrado.Apellidos = cliente.Apellidos;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Correo = cliente.Correo;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }

    }
}