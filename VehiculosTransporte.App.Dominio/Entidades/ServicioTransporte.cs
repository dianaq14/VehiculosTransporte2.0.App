using System;

namespace VehiculosTransporte.App.Dominio
{
    public class ServicioTransporte
    {
        public int Id { get; set; }
        public DateTime FechaServicio { get; set; }
        public string Recorrido { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public int ValorServicio { get; set; }
        public Cliente Cliente { get; set; }
    }
}