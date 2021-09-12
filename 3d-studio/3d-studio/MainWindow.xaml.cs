﻿using Cells;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
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
using System.Windows.Threading;
using System.Xml;
using WifViewer.ViewModels;

namespace WifViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();

            CheckForRaytracer();
        }

        private void CheckForRaytracer()
        {
            if ( !File.Exists(Configuration.RAYTRACER_PATH) )
            {
                MessageBox.Show(this, $"Could not find {Configuration.RAYTRACER_PATH}.\nYou will not be able to render images.\nOpen Configuration.cs, change the path and recompile.", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}
