using BlazorMDI.Shared.GridData;
using BlazorMDI.Shared.Navigation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;

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
                var appName = "app" + i;
                var appTitle = LoremNET.Lorem.Words(1, 3);

                var an = new NavTreeNode { Title = appTitle, HasNavigation = false, IsTopLevel = true };
                an.SubNodes.Add(new NavTreeNode
                {
                    Title = "Processes",
                    Icon = "fad fa-cogs",
                    HasNavigation = false,
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
                        Title = "Form Management", Icon="fad fa-pen-square", HasNavigation = true,
                        NavigateUrl = "FormManagement", AppName = appName, AppTitle = appTitle,
                        Description = "Create and design application forms", Badge = NodeBadgeEnum.New
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
                    Title = "Entities",
                    HasNavigation = false,
                    Icon = "fad fa-puzzle-piece",
                    Description = "Entities store user's data"
                });
                res.Add(an);
            }

            return res;
        }

        [HttpGet]
        [Route("GetFormsList")]
        public IEnumerable<FormMgmtGrid> GetFormsList(string appName)
        {
            var rnd = new Random();
            var myTI = new CultureInfo("en-US", false).TextInfo;
            var res = new List<FormMgmtGrid>();

            var max = rnd.Next(10, 30);
            for (int i = 0; i < max; i++)
            {
                var name = myTI.ToTitleCase(LoremNET.Lorem.Words(2, 3));
                var sname = name.Replace(" ", "");

                res.Add(new FormMgmtGrid
                {
                    Id = Guid.NewGuid(),
                    Name = $"frm{sname}",
                    Title = name,
                    ObjectName = $"App.{appName}.FormObject.{sname}DS",
                    LastModified = DateTime.Today.AddHours(-rnd.Next(1, 500))
                }
                );
            }

            return res;
        }

    }
}
