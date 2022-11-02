namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaracion o matricula de nuestas interfaces a nivel de repository
        ICategoryRepository Category { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
