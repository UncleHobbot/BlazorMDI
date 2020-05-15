using BlazorMDI.Server.DAL.Interfaces;
using BlazorMDI.Shared.Navigation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMDI.Server.DAL.Repositories.Fake
{
    public class NavigationRepo: INavigationRepo
    {
        public Task<IEnumerable<NavTreeNode>> GetNavTree()
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

            return Task.FromResult<IEnumerable<NavTreeNode>>(res);
        }
    }
}
