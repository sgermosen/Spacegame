using System;
using CocosSharp;
using CocosDenshion;

namespace SpaceGameCommon
{
    public class GameAppDelegate : CCApplicationDelegate
    {
        public override void ApplicationDidFinishLaunching (CCApplication application, CCWindow mainWindow)
        {
            application.PreferMultiSampling = false;
            application.ContentRootDirectory = "Content";
            application.ContentSearchPaths.Add ("sounds");
            application.ContentSearchPaths.Add ("particles");

            CCSize windowSize = mainWindow.WindowSizeInPixels;

            mainWindow.SetDesignResolutionSize (windowSize.Width, windowSize.Height, CCSceneResolutionPolicy.ShowAll);
            
            CCScene scene = new CCScene (mainWindow);
            GameLayer gameLayer = new GameLayer ();

            scene.AddChild (gameLayer);

            CCSimpleAudioEngine.SharedEngine.PreloadEffect ("sounds/explosion");
            CCSimpleAudioEngine.SharedEngine.PreloadEffect ("sounds/laser");

            mainWindow.RunWithScene (scene);
        }

        public override void ApplicationDidEnterBackground (CCApplication application)
        {
            application.Paused = true;
        }

        public override void ApplicationWillEnterForeground (CCApplication application)
        {
            application.Paused = false;
        }
    }
}
