﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Low-Level Xaml\ActivitySpinner.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7FB69B74F5DFDF878CEC4D9E788755B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverPotato {
    
    
    public partial class ActivitySpinner : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas cnvTopCanvas;
        
        internal System.Windows.Media.ScaleTransform stScaleTransform;
        
        internal System.Windows.Media.SolidColorBrush scbTintColour;
        
        internal System.Windows.Media.RotateTransform rotateTransform;
        
        internal System.Windows.Shapes.Rectangle rctMainRectangle;
        
        internal System.Windows.Shapes.Ellipse elpMainCircle;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Low-Level%20Xaml/ActivitySpinner.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.cnvTopCanvas = ((System.Windows.Controls.Canvas)(this.FindName("cnvTopCanvas")));
            this.stScaleTransform = ((System.Windows.Media.ScaleTransform)(this.FindName("stScaleTransform")));
            this.scbTintColour = ((System.Windows.Media.SolidColorBrush)(this.FindName("scbTintColour")));
            this.rotateTransform = ((System.Windows.Media.RotateTransform)(this.FindName("rotateTransform")));
            this.rctMainRectangle = ((System.Windows.Shapes.Rectangle)(this.FindName("rctMainRectangle")));
            this.elpMainCircle = ((System.Windows.Shapes.Ellipse)(this.FindName("elpMainCircle")));
        }
    }
}

