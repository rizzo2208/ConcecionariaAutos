using ConcecionariaAutos.data;
using ConcecionariaAutos.Repositorio;
using ConcecionariaAutos.Repositorio.Interface;

namespace ConcecionariaAutos.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IClientesRepository ClienteRepo { get; private set; }

        public IVentasRepository VentaRepo { get; private set; }

        public IVehiculoRepository VehiculoRepo { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ClienteRepo = new ClienteRepostory(context);
            VentaRepo = new VentaRepository(context);
            VehiculoRepo = new VehiculoRepository(context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
