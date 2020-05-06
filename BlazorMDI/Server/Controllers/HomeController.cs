using BlazorMDI.Shared.Navigation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
                var an = new NavTreeNode { Title = "Application " + i, HasNavigation = false, IsTopLevel = true};
                an.SubNodes.Add(new NavTreeNode
                {
                    Title = "Processes", Icon="fad fa-cogs", HasNavigation = false,
                    Description = "Processes allow to create a flow of data among forms"
                });
                an.SubNodes.Add(new NavTreeNode
                {
                    Title = "Forms",
                    HasNavigation = false,
                    SubNodes = new List<NavTreeNode>
                    {
                    new NavTreeNode
                    {
                        Title = "Form Management", Icon="fad fa-pen-square", HasNavigation = false,
                        Description = "Create and design application forms"
                    },
                    new NavTreeNode
                    {
                        Title = "Form Behaviours", Icon="fad fa-sliders-h-square", HasNavigation = false,
                        Description = "Create and edit Form Behaviours. Behaviour defines how and where form is using"
                    },
                    new NavTreeNode
                    {
                        Title = "Form Categories", Icon="fad fa-share-alt-square", HasNavigation = false,
                        Description = "Form Categories allow you to create menu hierarchies"
                    },
                    new NavTreeNode
                    {
                        Title = "Form Actions", Icon="fad fa-caret-square-right", HasNavigation = false,
                        Description = "Form Actions allow you to use complex logic (code and rules) on forms"
                    }
                }
                });
                an.SubNodes.Add(new NavTreeNode
                {
                    Title = "Entities", HasNavigation = false, Icon = "fad fa-puzzle-piece",
                    Description = "Entities store user's data"
                });
                res.Add(an);
            }

            return res;
        }
    }
}
