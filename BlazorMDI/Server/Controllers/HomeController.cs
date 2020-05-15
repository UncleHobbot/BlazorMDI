using BlazorMDI.Server.DAL.Repositories;
using BlazorMDI.Shared.GridData;
using BlazorMDI.Shared.Navigation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMDI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly RepoContainer _repoContainer;
        public HomeController(RepoContainer repoContainer)
        {
            _repoContainer = repoContainer;
        }

        [HttpGet]
        [Route("GetTree")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<NavTreeNode>>> GetNavTree() 
            => Ok(await _repoContainer.NavigationRepo.GetNavTree());

        [HttpGet]
        [Route("GetFormsList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FormMgmtGrid>>> GetFormsList(string appName)
            => Ok(await _repoContainer.FormsRepo.GetFormsList(appName));
    }
}
