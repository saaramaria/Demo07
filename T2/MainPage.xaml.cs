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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void markkaButton_Click(object sender, RoutedEventArgs e)
        {
            string markkaString = alkuRaha.Text;
            double markat = double.Parse(markkaString);
            markat = markat * 5.94573;
            muutettuRaha.Text = markat.ToString("0.00");
        }

        private void euroButton_Click(object sender, RoutedEventArgs e)
        {
            string euroString = alkuRaha.Text;
            double eurot = double.Parse(euroString);
            eurot = eurot * 0.17;
            muutettuRaha.Text = eurot.ToString("0.00");
        }
    }
}
