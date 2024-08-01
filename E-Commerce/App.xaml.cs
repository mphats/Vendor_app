using E_Commerce.view;

namespace E_Commerce
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LandingPage());
		}
	}
}
