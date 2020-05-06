using System.Collections.Generic;

namespace BlazorMDI.Shared.Navigation
{
    public class NavTreeNode
    {
        public string Title { get; set; }
        public bool IsTopLevel { get; set; } = false;
        public bool HasNavigation { get; set; }
        public string NavigateUrl { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

        public List<NavTreeNode> SubNodes { get; set; } = new List<NavTreeNode>();
    }
}
