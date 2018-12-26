using System;
using UIKit;
using Foundation;
using osuTK.Input;
using osuTK.Platform;

namespace osuTK.iOS
{
    public abstract class IOSAppDelegate : UIApplicationDelegate
    {
       
        public abstract override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions); // Exposing FinishedLaunching for osu-framework to handle

        private readonly FileDropEventArgs FileDropArgs = new FileDropEventArgs();



        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options) // File opening from external source. (Required Info.plist in game project)
        {
            var e = FileDropArgs;
            FileDropArgs.FileName = url.Path;
            FileDrop(this, e);
            return true;
        }
        /// <summary>
        /// Occurs whenever a file dropped on window;
        /// </summary>
        public event EventHandler<FileDropEventArgs> FileDrop = delegate { };
    }
}
