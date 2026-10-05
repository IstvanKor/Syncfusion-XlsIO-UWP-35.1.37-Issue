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
using Syncfusion.XlsIO;
using Windows.Storage;

namespace UWPTest01
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myButton.Content = "BEFORE";

                ExcelEngine excelEngine = new ExcelEngine();

                myButton.Content = "AFTER";

                excelEngine.Dispose();
            }
            catch (Exception ex)
            {
                myButton.Content = ex.GetType().FullName + "\n\n" + ex.Message;
            }
        }
    }
}
