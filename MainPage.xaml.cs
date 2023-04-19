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
using Microsoft.Toolkit.Uwp;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
public class CaroItem
{
    public string CItem
    {
        get;
        set;
    }
}
namespace Launcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<CaroItem> items = new ObservableCollection<CaroItem>();
        public MainPage()
        {
            this.InitializeComponent();
            items.Add(new CaroItem()
            {
                CItem = string.Format("ms-appx:///Images//01.jpg")
            });
            items.Add(new CaroItem()
            {
                CItem = string.Format("ms-appx:///Images//02.jpg")
            });
            items.Add(new CaroItem()
            {
                CItem = string.Format("ms-appx:///Images//03.jpg")
            });
            items.Add(new CaroItem()
            {
                CItem = string.Format("ms-appx:///Images//04.jpg")
            });
            items.Add(new CaroItem()
            {
                CItem = string.Format("ms-appx:///Images//05.jpg")
            });
            
            CaroTest.ItemsSource = items;
        }
    }
}
