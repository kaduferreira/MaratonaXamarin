using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Linq;

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
                var api = new MaratonaXamarin.Shared.UserApi();
                var users = await api.ListAsync(new Shared.Developer
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Carlos Eduardo",
                    Email = "kadu19@hotmail.com",
                    State = "Rio de Janeiro",
                    City = "Niterói"
                });

                lvwItens.Source = new TableViewSource(users.OrderBy(u => u.Name).Select(u => u.Name).ToList());
                lvwItens.ReloadData();
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}