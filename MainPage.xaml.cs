﻿using AdeptlyAdaptiveChallenge044.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AdeptlyAdaptiveChallenge044
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewsItem> NewsItems;
        public MainPage()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItem>();
        }

        public ObservableCollection<NewsItem> NewsItem { get; }

        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            splitViewMenu.IsPaneOpen = !splitViewMenu.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (financialListItem.IsSelected)
            {
                NewsManager.GetNews("Financial", NewsItems);
                titleTextBlock.Text = "Financial";
            }
            else if (foodListItem.IsSelected)
            {
                NewsManager.GetNews("Food", NewsItems);
                titleTextBlock.Text = "Food";
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            financialListItem.IsSelected = true;
        }
    }
}
