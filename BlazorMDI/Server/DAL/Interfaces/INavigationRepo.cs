using BlazorMDI.Shared.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMDI.Server.DAL.Interfaces
{
    public interface INavigationRepo
    {
        Task<IEnumerable<NavTreeNode>> GetNavTree();
    }
}
