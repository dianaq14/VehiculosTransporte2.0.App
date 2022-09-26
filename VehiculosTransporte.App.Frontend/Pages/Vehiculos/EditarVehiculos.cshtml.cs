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
    public class EditarVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo;
        [BindProperty]
        public Vehiculo vehiculo {get; set;}
        public EditarVehiculosModel()
        {
            this._repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        }
        public IActionResult OnGet(int? vehiculoId)
        {
            if(vehiculoId.HasValue)
            {
                vehiculo = _repoVehiculo.GetVehiculo(vehiculoId.Value);
            }
            else
            {
                vehiculo= new Vehiculo();
            }
            if(vehiculo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
        public IActionResult  OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if (vehiculo.Id >0)
            {
                vehiculo = _repoVehiculo.UpdateVehiculo(vehiculo);
            }
            else
            {
                _repoVehiculo.AddVehiculo( vehiculo);
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
