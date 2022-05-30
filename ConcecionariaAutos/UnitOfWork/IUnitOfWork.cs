using ConcecionariaAutos.data;

using ConcecionariaAutos.Repositorio.Interface;

namespace ConcecionariaAutos.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClientesRepository ClienteRepo { get; }
        IVentasRepository VentaRepo { get; }
        IVehiculoRepository VehiculoRepo { get; }
        void Save();
    }
    
}
