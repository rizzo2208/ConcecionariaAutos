using ApiProyectoVideoClub.Repository;
using ConcecionariaAutos.data;
using ConcecionariaAutos.Entity;
using ConcecionariaAutos.Repositorio.Interface;
namespace ConcecionariaAutos.Repositorio
{
    public class VentaRepository : GenericRepository<Venta>, IVentasRepository
    {
        public VentaRepository(AppDbContext db) : base(db)
        {

        }
    }
}
