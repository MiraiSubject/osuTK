using System;
using UIKit;
using Foundation;
using osuTK.Input;
using osuTK.Platform;

namespace osuTK
{
    public abstract class IOSAppDelegate : UIApplicationDelegate
    {

       /* public abstract override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions); // Exposing FinishedLaunching for osu-framework


        private readonly FileDropEventArgs FileDropArgs = new FileDropEventArgs();
        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
           
            var e = this.FileDropArgs;
            FileDropEventArgs fileDropArgs = FileDropArgs;
            fileDropArgs.FileName = url.Path;
            
            return true;
        }*/
    }
}
