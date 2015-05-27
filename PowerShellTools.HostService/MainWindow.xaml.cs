﻿using PowerShellTools.HostService.ServiceManagement.Debugging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PowerShellTools.HostService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Visibility = System.Windows.Visibility.Visible;
            this.ShowInTaskbar = false;
            this.Title = string.Format(
                    PowerShellTools.Common.Constants.HostProcessWindowTitleFormat, 
                    App.VsProcessId, 
                    PowerShellTools.Common.Constants.PowerShellHostExeName);
            this.Left = -1000;
            this.Top = -1000;

            ConsoleManager.AttachConsole();
        }
    }
}
