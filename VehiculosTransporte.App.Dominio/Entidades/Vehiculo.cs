using System;

namespace VehiculosTransporte.App.Dominio
{
    public class Vehiculo
    {
        public int Id {get; set;}
        public int placa {get; set;}
        public string marca { get; set; }
        public string modelo_año { get; set; }
        public string tipo { get; set; }
        public string CapacidadPasajeros { get; set; }
        public Duenio Duenio { get; set; }
        public Mecanico Mecanico { get; set; }
        public Conductor Conductor { get; set; }
        public DateTime Soat { get; set; }
        public DateTime SeguroContractual { get; set; }
        public DateTime SeguroExtracontractual { get; set; }
        public DateTime RevisionTecnicoMecanica { get; set; }
        //public List<Revision> Revisiones { get; set; }
    }
}