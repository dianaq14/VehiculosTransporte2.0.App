using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class ListaMecanicosModel : PageModel
    {
        private static IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
        public IEnumerable<Mecanico> listaMecanicos { get; set; }
        
        public void OnGet()
        {
            listaMecanicos = _repoMecanico.GetAllMecanicos();
        }
    }
}
