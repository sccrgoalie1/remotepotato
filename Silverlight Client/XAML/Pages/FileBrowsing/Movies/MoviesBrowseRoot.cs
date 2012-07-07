﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using CommonEPG;

namespace SilverPotato
{
    public class MoviesBrowseRoot : FileBrowseRoot
    {

        public MoviesBrowseRoot()
            : base()
        {
            Initialize("MOVIE_LIBRARY", ClickItemsPane.ClickItemsPaneItemLayouts.Thumbnails);
        }

        void Initialize(string RootPath, ClickItemsPane.ClickItemsPaneItemLayouts rootFolderClickItemsPaneItemLayout)
        {
            if (IsInitialized) return;

            // Load the first folder...
            FileBrowseRequest fbRequest = new FileBrowseRequest();
            fbRequest.FullPath = RootPath;
            fbRequest.GetDurationOfMediaFiles = true;

            MoviesBrowseFolder rootFolder = new MoviesBrowseFolder(this, fbRequest, rootFolderClickItemsPaneItemLayout);
            PushFolder(rootFolder);
            IsInitialized = true;
        }
    }
}
