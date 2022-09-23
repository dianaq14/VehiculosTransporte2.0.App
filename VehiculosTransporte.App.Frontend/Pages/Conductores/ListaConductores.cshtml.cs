using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Persistencia;
using VehiculosTransporte.App.Dominio;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class ListaConductoresModel : PageModel
    {
        private static IRepositorioConductor _repoConductor = new RepositorioConductor(new Persistencia.AppContext());
        public IEnumerable<Conductor> listaConductores { get; set; }
        public void OnGet()
        {
            listaConductores = _repoConductor.GetAllConductores();
        }
    }
}
