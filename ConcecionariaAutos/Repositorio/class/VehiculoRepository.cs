using ApiProyectoVideoClub.Repository;
using ConcecionariaAutos.data;
using ConcecionariaAutos.Entity;
using ConcecionariaAutos.Repositorio.Interface;

namespace ConcecionariaAutos.Repositorio
{
    public class VehiculoRepository : GenericRepository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(AppDbContext db) : base(db)
        {

        }
    }
}
