using BlazorMDI.Server.DAL.Interfaces;

namespace BlazorMDI.Server.DAL.Repositories
{
    public class RepoContainer
    {
        public INavigationRepo NavigationRepo { get; }
        public IFormsRepo FormsRepo { get; }

        public RepoContainer(INavigationRepo navRepo, IFormsRepo formsRepo)
        {
            NavigationRepo = navRepo;
            FormsRepo = formsRepo;
        }
    }
}
