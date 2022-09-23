using System;

namespace VehiculosTransporte.App.Dominio
{
    public class Revision
    {
        //<summary>class<c>signo vital</c>
        public int Id { get; set; }
        public DateTime FechaRevision { get; set; }
        public string NivelAceite { get; set; }
        public string NivelLiquidoFrenos { get; set; }
        public string NivelRefrigerante { get; set; }
        public string NivelLiquidoDireccion { get; set; }
        public string Repuestos { get; set; }
        public int ValorRepuestos { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }

}
