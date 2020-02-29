using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace linli.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // 显示指示器
            Forms.SetFlags("IndicatorView_Experimental");

            global::Xamarin.Forms.Forms.Init();

            App.ScreenWidth = UIScreen.MainScreen.Bounds.Width; //屏幕宽度

            App.ScreenHeight = UIScreen.MainScreen.Bounds.Height; //屏幕高度



            LoadApplication(new App());

            return base.FinishedLaunching(app, options);

        }
    }
}
