using MatchApp.View;

namespace MatchApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MatchView();
        }
    }
}
