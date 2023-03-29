﻿using System.Windows;
using System.Windows.Controls;

namespace Axios
{
    public partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            InitializeComponent();
            MinimizeOnCloseCheckBox.IsChecked = Properties.Settings.Default.MinimizeOnExit;
            MinimizeOnCloseCheckBox.IsChecked = (bool)MinimizeOnCloseCheckBox.IsChecked;
        }

        private void SaveSettingsBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (MinimizeOnCloseCheckBox != null)
            {
                Properties.Settings.Default.MinimizeOnExit = (bool)MinimizeOnCloseCheckBox.IsChecked;
                Properties.Settings.Default.Save();
            }
        }
    }
}
