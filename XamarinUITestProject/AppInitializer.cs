using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinUITestProject
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                //return ConfigureApp.Android.InstalledApp("com.companyname.xamarinapp_android").StartApp();
                return ConfigureApp.Android.ApkFile(@"C:\ApkFiles\MultiTouchTester.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }


        
    }
}