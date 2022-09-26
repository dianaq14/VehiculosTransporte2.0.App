using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class ListaVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppContext());
        public IEnumerable<Vehiculo> ListaVehiculos {get; set;}
        public string FiltroBusqueda{get;set;}
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaVehiculos =  _repoVehiculo.GetAllVehiculos();
            }
            else
            {
                ListaVehiculos =  _repoVehiculo.BuscarVehiculo(filtroBusqueda);
            }
        
        }
               
        public IActionResult OnPostDelete(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoVehiculo.DeleteVehiculo(Id);
            return RedirectToAction("Get");
        }
    }
}
