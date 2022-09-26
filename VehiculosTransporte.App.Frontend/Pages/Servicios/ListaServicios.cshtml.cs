using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class ListaServiciosModel : PageModel
    {
        private static IRepositorioServicioTransporte _repoServicios = new RepositorioServicioTransporte(new Persistencia.AppContext());
        public IEnumerable<ServicioTransporte> listaServicios { get; set; }
        
        public void OnGet()
        {
            listaServicios = _repoServicios.GetAllServicios();
        }
    }
}
