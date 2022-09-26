using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;

namespace VehiculosTransporte.App.Frontend.Pages
{
    public class DetallesVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _RepoVehiculo;
        public Vehiculo vehiculo {get; set;}
        public DetallesVehiculosModel()
        {
            this._RepoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int Vehiculoplaca)
        {
            vehiculo = _RepoMecanico.GetMecanico(Vehiculoplaca);
            if(vehiculo == null)
            {
                return RedirectToPage("./NOTFOUND");
            }
            else
            {
                return Page();
            }
        }
    }
}