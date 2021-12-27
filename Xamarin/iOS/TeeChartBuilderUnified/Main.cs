using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace TeeChartBuilder
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window.AddSubview (navigationController.View);
			window.MakeKeyAndVisible ();
			navigationController.NavigationBar.Opaque = true;
			navigationController.NavigationBar.Translucent = false;

			window.RootViewController = navigationController;
			return true;
		}

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}	
	}
}