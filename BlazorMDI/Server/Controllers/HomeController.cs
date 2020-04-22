using System.Collections.Generic;
using BlazorMDI.Shared.Navigation;
using Microsoft.AspNetCore.Mvc;

namespace BlazorMDI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("GetTree")]
        public IEnumerable<NavTreeNode> GetNavTree()
        {
            var res = new List<NavTreeNode>();
            
            for (var i = 1; i < 10; i++)
            {
                var an = new NavTreeNode { Title = "Application " + i, HasNavigation = false };
                an.SubNodes.Add(new NavTreeNode { Title = "Processes", HasNavigation = false });
                an.SubNodes.Add(new NavTreeNode
                {
                    Title = "Forms",
                    HasNavigation = false,
                    SubNodes = new List<NavTreeNode>
                    {
                    new NavTreeNode {Title = "Form Management", HasNavigation = false},
                    new NavTreeNode {Title = "Form Behaviours", HasNavigation = false},
                    new NavTreeNode {Title = "Form Actions", HasNavigation = false}
                }
                });
                an.SubNodes.Add(new NavTreeNode { Title = "Entities", HasNavigation = false });
                res.Add(an);
            }

            return res;
        }
    }
}
