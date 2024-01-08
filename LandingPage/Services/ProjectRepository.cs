using LandingPage.Models;

namespace LandingPage.Services
{
    public interface IProjectRepository
    {
        List<Project> generateProjects();
    }
    public class ProjectRepository : IProjectRepository
    {
        public List<Project> generateProjects()
        {
            return new List<Project>()
            {
                new Project()
                {
                    title = "21 Blackjack",
                    description = "Android application of a 21 Blackjack game using Jetpack Compose in Android Studio. Compatible with Android 7.0+.",
                    imageLocation="/images/blackjack.png"
                },
                new Project()
                {
                    title = "Periodic Table",
                    description = "Android application with the first 50 elements in the periodic table"+
                    " using Jetpack Compose in Android Studio. Comptaible with Android 7.0+.",
                    imageLocation="/images/periodic.png"

                },
            };
        }
    }
}
