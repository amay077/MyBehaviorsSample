using Xamarin.Forms;

namespace MyBehaviorsSample
{
	public partial class App : Application
	{
		public App()
		{
			//MyBehaviorsLib.Initializer.Init();
			
			InitializeComponent();
			MainPage = new MyBehaviorsSamplePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
