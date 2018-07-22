﻿using System;
using System.IO;
using AppKit;
using Foundation;
using Hotsapi.Uploader.Common;

namespace Hotsapi.Uploader.Mac
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public Manager Manager
        {
            get;
            set;
        }

        public Settings Settings
        {
            get;
            set;
        }

        public static string SettingsDir { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Hotsapi"); } }

        public AppDelegate()
        {
            Manager = new Manager(new ReplayStorage(Path.Combine(SettingsDir, "replays.xml")));
            // Enable collection modification from any thread
            Settings = new Settings(NSUserDefaults.StandardUserDefaults);
            Manager.UploadToHotslogs = Settings.UploadToHotsLogs;
            Manager.DeleteAfterUpload = Settings.DeleteAfterUpload;
        }
        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application

        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
