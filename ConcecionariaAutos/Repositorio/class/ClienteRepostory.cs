using ApiProyectoVideoClub.Repository;
using ConcecionariaAutos.data;
using ConcecionariaAutos.Entity;
using ConcecionariaAutos.Repositorio.Interface;

namespace ConcecionariaAutos.Repositorio
{
    public class ClienteRepostory : GenericRepository<Cliente>, IClientesRepository
    {
        public ClienteRepostory(AppDbContext db) : base(db)
        {

        }
    }
}
