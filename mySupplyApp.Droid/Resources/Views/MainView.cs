using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;
using mySupplyApp.Core.ViewModels;

namespace mySupplyApp.Droid.Resources.Views
{
    [Activity(Label = "Main", MainLauncher = true)]
    public class MainView : MvxActivity<TempViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
        }
    }
}