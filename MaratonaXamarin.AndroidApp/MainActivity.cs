using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Linq;

namespace MaratonaXamarin.AndroidApp
{
    [Activity(Label = "MaratonaXamarin.AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var button = this.FindViewById<Button>(Resource.Id.btnCarregar);
            var listView = this.FindViewById<ListView>(Resource.Id.ltwItens);

            button.Click += async (sender, e) =>
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

                listView.Adapter = new ArrayAdapter(this,
                Android.Resource.Layout.SimpleListItemSingleChoice,
                users
                    .OrderBy(y => y.Name)
                    .Select(x => $"{x.Id} {x.Name}")
                    .ToArray()
                );
            };
        }
    }
}