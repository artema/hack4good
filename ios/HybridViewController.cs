using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace iPhone
{
    public partial class HybridViewController : UIViewController
    {
        private const string MainUrl = "http://hack4good.elasticbeanstalk.com/";//"http://172.18.30.155:8080/";//

        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public HybridViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Intercept URL loading to handle native calls from browser
            webView.ShouldStartLoad += HandleShouldStartLoad;

            webView.LoadRequest(new NSUrlRequest(new NSUrl(MainUrl)));

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion

        bool HandleShouldStartLoad(UIWebView webView, NSUrlRequest request, UIWebViewNavigationType navigationType)
        {

            // If the URL is not our own custom scheme, just let the webView load the URL as usual
            var scheme = "app:";

            if (request.Url.Scheme != scheme.Replace(":", ""))
                return true;

            var resources = request.Url.ResourceSpecifier.Split('?');
            var method = resources[0];

            if (method == "QR")
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner();
                scanner.Scan().ContinueWith(result => {
                    if (result != null){
                        var code = result.Result.Text;
                        this.InvokeOnMainThread(new NSAction(() => webView.LoadRequest(new NSUrlRequest(new NSUrl(MainUrl + "code?value=" + code)))));
                    }
                });
            }

            return false;
        }
    }
}

