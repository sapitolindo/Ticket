using BasicApp.Functions;
using BasicApp.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("SourceCodePro-MediumItalic.ttf", Alias = "SourceCodePro-MediumItalic")]
[assembly: ExportFont("SourceCodePro-Medium.ttf", Alias = "SourceCodePro-Medium")]
namespace BasicApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<AddUser>();
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
