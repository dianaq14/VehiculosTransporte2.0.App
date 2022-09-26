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
    public class RegistrarVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppContext());
        private readonly IRepositorioDuenio _repoDuenio= new RepositorioDuenio(new Persistencia.AppContext());
        public IEnumerable<Duenio>? ListaDuenio {get; set;}
        private readonly IRepositorioConductor _repoConductor= new RepositorioConductor(new Persistencia.AppContext());
        public IEnumerable<Conductor>? ListaConductor {get; set;}
        private readonly IRepositorioMecanico _repoMecanico= new RepositorioMecanico(new Persistencia.AppContext());
        public IEnumerable<Mecanico>? ListaMecanico {get;set;}

        [BindProperty]
        public Vehiculo NewVehiculo { get; set; } = new();
        public IEnumerable<Vehiculo> BuscaVehiculo {get; set;}
        public int existe {get;set;}
        public string vehiculoplaca {get;set;}
        public void OnGet()
        {
             ListaDuenio = _repoDuenio.GetAllDuenios();
             ListaConductor = _repoConductor.GetAllConductores();
             ListaMecanico = _repoMecanico.GetAllMecanicos();
             existe=0;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoVehiculo.AddVehiculo(NewVehiculo);
            return RedirectToPage("./ListaVehiculos");
        }
    }
}