using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
using MyStoreApps.MyService;
namespace MyStoreApps
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MyServiceSoapClient myService = new MyServiceSoapClient();
        public MainPage()
        {
            this.InitializeComponent();
            List<string> title = new List<string>()
            {
                "Mr.",
                "Mrs.",
                "Miss.",
                "Md."
            };
            this.cmbTitle.ItemsSource = title;
        }

        private async void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            //var a = await myService.In
        }
    }
}
