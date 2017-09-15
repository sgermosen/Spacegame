using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CocosSharp;
using SpaceGameCommon;

namespace Spacegame
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override void FinishedLaunching (UIApplication app)
        {
            var application = new CCApplication ();
            application.ApplicationDelegate = new GameAppDelegate ();
            application.StartGame ();
        }

        static void Main (string[] args)
        {
            UIApplication.Main (args, null, "AppDelegate");
        }
    }
}