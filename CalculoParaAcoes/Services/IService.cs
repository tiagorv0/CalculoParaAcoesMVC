using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalculoParaAcoesMVC.Services
{
    public interface IService<T>
    {
        Task<List<T>> FindAllAsync();
        Task InsertAsync(T obj);
        Task<T> FindByIdAsync(int id);
        Task RemoveAsync(int id);
        Task UpdateAsync(T obj);
        T AtribuirValores(T obj);

    }
}
