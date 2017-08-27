﻿using HotsapiUploader.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace HotsapiUploader.Windows.UIHelpers
{
    public class IntToVisibilityConverter : GenericValueConverter<Dictionary<UploadStatus, int>, Visibility, UploadStatus>
    {
        protected override Visibility Convert(Dictionary<UploadStatus, int> value, UploadStatus parameter)
        {
            return value.ContainsKey(parameter) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
