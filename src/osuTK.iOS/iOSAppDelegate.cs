using UIKit;
using Foundation;
namespace osuTK.iOS
{
    public abstract class iOSAppDelegate : UIApplicationDelegate
    {
        public iOSGameView gameView { get; set; }

        [Export("application:openURL:options:")]
        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
           if (url.IsFileUrl)
                {
                    gameView.OnFileDrop(url.Path);
                }
            else
            {
                //TODO: not a file.
            }
            return true;

        }
    }
}
