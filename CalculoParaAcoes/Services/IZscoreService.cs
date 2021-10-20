using System.Collections.Generic;
using System.Threading.Tasks;
using CalculoParaAcoes.Models;
using CalculoParaAcoesMVC.Models.ViewModels;

namespace CalculoParaAcoesMVC.Services
{
    public interface IZscoreService
    {
        Task<List<ZscoreModel>> ListarAsync();

        Task CadastrarAsync(ZscoreViewModel zscoreViewModel);
    }
}
