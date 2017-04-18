﻿using Microsoft.WindowsAzure.MobileServices;
using System;

using UIKit;

namespace MaratonaXamarin.iOSApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            CurrentPlatform.Init();

            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.btnCarregar.TouchUpInside += async (sender, e) =>
            {

            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}