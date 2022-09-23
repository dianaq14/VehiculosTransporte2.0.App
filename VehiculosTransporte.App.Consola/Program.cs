using System;
using VehiculosTransporte.App.Dominio;
using VehiculosTransporte.App.Persistencia;


namespace VehiculosTransporte.App.Consola
{
    class Program 
    {
        private static IRepositorioJefeOperaciones _repoJefeOperaciones=new RepositorioJefeOperaciones(new Persistencia.AppContext()); 
        private static IRepositorioConductor _repoConductor =new RepositorioConductor(new Persistencia.AppContext());
        private static IRepositorioVehiculo _repoVehiculo =new RepositorioVehiculo(new Persistencia.AppContext());
        private static IRepositorioDuenio _repoDuenio =new RepositorioDuenio(new Persistencia.AppContext());
        private static IRepositorioMecanico _repoMecanico =new RepositorioMecanico(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework");
            //AddJefeOperaciones();
            //GetJefeOperaciones(1);
            //DeleteJefeOperaciones(2);

            //AddConductor();
            //GetConductor();
            //DeleteConductor();
            //Addmecanico();
            //AddMecanico();
            //AddDuenio();
        }
        private static void AddJefeOperaciones()
        {
            var jefeOperaciones= new JefeOperaciones
            {
                Nombres="Juan Fernando",
                Apellidos="Velazco",
                Correo="jfvelazco@gmail.com",
                Telefono="555789541"
            };
            _repoJefeOperaciones.AddJefeOperaciones(jefeOperaciones);
        }
        private static void GetJefeOperaciones(int idJefeOperaciones)
        {
            var jefeOperaciones= _repoJefeOperaciones.GetJefeOperaciones(idJefeOperaciones);
            Console.WriteLine(jefeOperaciones.Nombres+" "+jefeOperaciones.Apellidos);
        }
        //Conductor

        private static void AddConductor()
        {
            var conductor = new Conductor
            {
                Nombres="Francisco",
                Apellidos="Alarcon",
                Correo="isco22@gmail.com",
                Telefono="63465398",
                LicenciaConduccion="546143C"
            };
            _repoConductor.AddConductor(conductor);
        }

        private static void GetConductor(int idConductor)
        {
            var conductor= _repoConductor.GetConductor(idConductor);
             Console.WriteLine(conductor.Nombres +" "+conductor.Apellidos +" "+conductor.LicenciaConduccion);
        }

        //mecanico
            private static void AddMecanico()
            {
                var mecanico = new Mecanico
                {
                    Nombres = "Santiago",
                    Apellidos = "Fernadez",
                    Correo = "santiagofdz@gmail.com",
                    Telefono = "310875643",
                };
                _repoMecanico.AddMecanico(mecanico);
            }

            private static void GetMecanico(int idMecanico)
            {
                var mecanico = _repoMecanico.GetMecanico(idMecanico);
                Console.WriteLine(mecanico.Nombres+" "+mecanico.Apellidos);
            }

        //Duenio
        private static void AddDuenio()
        {
            var duenio = new Duenio
            {
                Nombres="Pablo",
                Apellidos="Giraldo",
                Correo="pablo12giraldo@gmail.com",
                Telefono="3217654103"
            };
            _repoDuenio.AddDuenio(duenio);
        }
        private static void GetDuenio(int idDuenio)
        {
            var duenio= _repoDuenio.GetDuenio(idDuenio);
             Console.WriteLine(duenio.Nombres+" "+duenio.Apellidos);
        }

       
   
    }
}
