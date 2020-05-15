using BlazorMDI.Shared.GridData;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMDI.Server.DAL.Interfaces
{
    public interface IFormsRepo
    {
        Task<IEnumerable<FormMgmtGrid>> GetFormsList(string appName);
    }
}