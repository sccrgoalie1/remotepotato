﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Pages\FileBrowsing\Pictures\PictureViewingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "15BE4B6DDDE81D58AA78002B4075D9DE"
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
    
    
    public partial class PictureViewingPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid gdCurrentPicture;
        
        internal System.Windows.Media.ScaleTransform scaleTransform;
        
        internal System.Windows.Controls.Image imgCurrentPicture;
        
        internal System.Windows.Controls.Grid gdOverlayPicture;
        
        internal System.Windows.Media.ScaleTransform scaleTransformOverlay;
        
        internal System.Windows.Controls.Image imgOverlayPicture;
        
        internal System.Windows.Controls.Border brdOSDTop;
        
        internal System.Windows.Controls.Border btnTopNavBack;
        
        internal System.Windows.Controls.TextBlock lblPicTitle;
        
        internal System.Windows.Controls.ComboBox cmbPictureQuality;
        
        internal System.Windows.Controls.StackPanel spZoomLevel;
        
        internal System.Windows.Controls.Slider sldZoomLevel;
        
        internal System.Windows.Controls.Border btnStartStopSlideshow;
        
        internal System.Windows.Shapes.Rectangle rctSlideShowIntervalTime;
        
        internal System.Windows.Controls.Image imgStartStopSlideshow;
        
        internal System.Windows.Controls.Border btnToggleFullScreen;
        
        internal System.Windows.Controls.Border brdOSDbottom;
        
        internal System.Windows.Controls.Border btnMovePrev;
        
        internal System.Windows.Media.Effects.DropShadowEffect dropShadowLeftArrow;
        
        internal System.Windows.Controls.Border btnMoveNext;
        
        internal System.Windows.Media.Effects.DropShadowEffect dropShadowRightArrow;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Pages/FileBrowsing/Pictures/PictureViewingPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.gdCurrentPicture = ((System.Windows.Controls.Grid)(this.FindName("gdCurrentPicture")));
            this.scaleTransform = ((System.Windows.Media.ScaleTransform)(this.FindName("scaleTransform")));
            this.imgCurrentPicture = ((System.Windows.Controls.Image)(this.FindName("imgCurrentPicture")));
            this.gdOverlayPicture = ((System.Windows.Controls.Grid)(this.FindName("gdOverlayPicture")));
            this.scaleTransformOverlay = ((System.Windows.Media.ScaleTransform)(this.FindName("scaleTransformOverlay")));
            this.imgOverlayPicture = ((System.Windows.Controls.Image)(this.FindName("imgOverlayPicture")));
            this.brdOSDTop = ((System.Windows.Controls.Border)(this.FindName("brdOSDTop")));
            this.btnTopNavBack = ((System.Windows.Controls.Border)(this.FindName("btnTopNavBack")));
            this.lblPicTitle = ((System.Windows.Controls.TextBlock)(this.FindName("lblPicTitle")));
            this.cmbPictureQuality = ((System.Windows.Controls.ComboBox)(this.FindName("cmbPictureQuality")));
            this.spZoomLevel = ((System.Windows.Controls.StackPanel)(this.FindName("spZoomLevel")));
            this.sldZoomLevel = ((System.Windows.Controls.Slider)(this.FindName("sldZoomLevel")));
            this.btnStartStopSlideshow = ((System.Windows.Controls.Border)(this.FindName("btnStartStopSlideshow")));
            this.rctSlideShowIntervalTime = ((System.Windows.Shapes.Rectangle)(this.FindName("rctSlideShowIntervalTime")));
            this.imgStartStopSlideshow = ((System.Windows.Controls.Image)(this.FindName("imgStartStopSlideshow")));
            this.btnToggleFullScreen = ((System.Windows.Controls.Border)(this.FindName("btnToggleFullScreen")));
            this.brdOSDbottom = ((System.Windows.Controls.Border)(this.FindName("brdOSDbottom")));
            this.btnMovePrev = ((System.Windows.Controls.Border)(this.FindName("btnMovePrev")));
            this.dropShadowLeftArrow = ((System.Windows.Media.Effects.DropShadowEffect)(this.FindName("dropShadowLeftArrow")));
            this.btnMoveNext = ((System.Windows.Controls.Border)(this.FindName("btnMoveNext")));
            this.dropShadowRightArrow = ((System.Windows.Media.Effects.DropShadowEffect)(this.FindName("dropShadowRightArrow")));
        }
    }
}
