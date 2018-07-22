using System;
using Foundation;
using Hotsapi.Uploader.Common;

namespace Hotsapi.Uploader.Mac
{
    public class Settings
    {
        private readonly NSUserDefaults _userDefaults;

        public const string UploadToHotsLogsKey = "UploadToHotsLogs";
        public const string StartWithSystemKey = "StartWithSystem";
        public const string MinimizeToTrayKey = "MinimizeToTray";
        public const string DeleteAfterUploadKey = "DeleteAfterUpload";

        public bool UploadToHotsLogs
        {
            get 
            {
                return _userDefaults.BoolForKey(UploadToHotsLogsKey);
            }
            set 
            {
                _userDefaults.SetBool(value, UploadToHotsLogsKey);
            }
        }

        public bool StartWithSystem
        {
            get 
            {
                return _userDefaults.BoolForKey(StartWithSystemKey);
            }
            set 
            {
                _userDefaults.SetBool(value, StartWithSystemKey);
            }
        }

        public bool MinimizeToTray
        {
            get
            {
                return _userDefaults.BoolForKey(MinimizeToTrayKey);
            }
            set
            {
                _userDefaults.SetBool(value, MinimizeToTrayKey);
            }
        }

        public DeleteFiles DeleteAfterUpload
        {
            
            get
            {
                return (DeleteFiles)(int) _userDefaults.IntForKey(DeleteAfterUploadKey);
            }
            set
            {
                _userDefaults.SetInt((int)value, DeleteAfterUploadKey);
            }
        }

        public Settings(NSUserDefaults defaults)
        {
            _userDefaults = defaults;
        }
    }
}
