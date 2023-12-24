using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaIngresoFMP.Server.Models;
using PruebaIngresoFMP.Shared.Models;

namespace PruebaIngresoFMP.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Aspirantes> Aspirantes { get; set; }
        public DbSet<EstadosPrueba> Estadospruebas { get; set; }
        public DbSet<LenguajesProgramacion> LenguajesProgramacions { get; set; }
        public DbSet<NivelPrueba> NivelPruebas { get; set; }
        public DbSet<Pruebas> Pruebas { get; set; }
        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<PruebasSeleccion> PruebasSeleccions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Crear datos semilla
            var aspirantes = new List<Aspirantes>();

            for (int i = 1; i <= 15; i++)
            {
                var name = Faker.Name.FullName();
                var reg = new Aspirantes 
                {
                    Id = i,
                    Nombres = Faker.Name.First(),
                    Apellidos = Faker.Name.Last(),
                    Direccion = Faker.Address.StreetAddress(true),
                    Identificacion = Faker.RandomNumber.Next(10),
                    Email = Faker.Internet.Email(name),
                    Telefono = Faker.Phone.Number(),
                };
                aspirantes.Add(reg);
            }

            var estados = new List<EstadosPrueba>() {
                    new() { Id= 1, Descripcion = "Registrada"},
                    new() { Id= 2, Descripcion = "En proceso"},
                    new() { Id= 3, Descripcion = "Terminada"},
                    new() { Id= 4, Descripcion = "Anulada"},
            };

            var lenguajes = new List<LenguajesProgramacion>() {
                    new() { Id= 1, Nombre = "Java" , Descripcion = "SDK Java"},
                    new() { Id= 2, Nombre = "C#", Descripcion = ".Net C#"},
                    new() { Id= 3, Nombre = "Javascript", Descripcion = "Javascript"},
                    new() { Id= 4, Nombre = "Go", Descripcion = "GoLang"},
            };

            var niveles = new List<NivelPrueba>()
            {
                new() { Id= 1, Nombre = "Junior" },
                new() { Id= 2, Nombre = "Middle" },
                new() { Id= 3, Nombre = "Senior" },
            };

            var pruebas = new List<Pruebas>();
            var pregutas = new List<Preguntas>();

            var idpregunta = 1;

            for (int i = 1; i <= 5; i++)
            {
                var prueba = new Pruebas
                {
                    Id = i,
                    Codigo = i.ToString("000000"),
                    Nombre = Faker.Lorem.Sentence(),
                    Descripcion = Faker.Lorem.Words(1).FirstOrDefault(),
                    LenguajesProgramacionId = lenguajes[Random.Shared.Next(1, 4)].Id,
                    NivelPruebaId = niveles[Random.Shared.Next(1, 3)].Id,
                    Cantidadpreguntas = 2,
                    Tipoprueba = "Tecnica"
                };
                pruebas.Add(prueba);

                for (int j = 0; j <= 2; j++)
                {
                    pregutas.Add(new Preguntas 
                    {
                        Id = idpregunta,
                        PruebasId = prueba.Id,
                        Pregunta = Faker.Lorem.Sentence(),
                        Respuesta = Faker.Lorem.Sentence()
                    });   
                    idpregunta++;
                }
            }

            var preguntasselect = new List<PruebasSeleccion>();
            for (int i = 1; i <= 20; i++)
            {
                var reg = new PruebasSeleccion
                {
                    Id = i,
                    AspiranteId = Faker.RandomNumber.Next(1, 15),
                    EstadospruebasId = Faker.RandomNumber.Next(1, 4),
                    PruebasId = Faker.RandomNumber.Next(1,5),
                    Calificacion = Faker.RandomNumber.Next(1, 100),
                    Fechainicio = DateTime.Now.AddMinutes(i-1),
                    Fechafinalizacion = DateTime.Now.AddHours(Faker.RandomNumber.Next(1, 3))
                };
                preguntasselect.Add(reg);
            }

            builder.Entity<Aspirantes>(o => { o.HasKey(a => a.Id); o.HasData(aspirantes); });
            builder.Entity<EstadosPrueba>(o => { o.HasKey(a => a.Id); o.HasData(estados); });
            builder.Entity<LenguajesProgramacion>(o => { o.HasKey(a => a.Id); o.HasData(lenguajes); });
            builder.Entity<NivelPrueba>(o => { o.HasKey(a => a.Id); o.HasData(niveles); });
            builder.Entity<Pruebas>(o => { o.HasKey(a => a.Id); o.HasData(pruebas); });
            builder.Entity<Preguntas>(o => { o.HasKey(a => a.Id); o.HasData(pregutas); });
            builder.Entity<PruebasSeleccion>(o => { o.HasKey(a => a.Id); o.HasData(preguntasselect); });

            base.OnModelCreating(builder);
        }
    }
}
