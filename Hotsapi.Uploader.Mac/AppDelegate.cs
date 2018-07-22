using System;
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

        public static string SettingsDir { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Hotsapi"); } }

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application

            Manager = new Manager(new ReplayStorage($@"{SettingsDir}\replays.xml"));
            // Enable collection modification from any thread

            Manager.UploadToHotslogs = false;
            Manager.DeleteAfterUpload = DeleteFiles.None;

            Manager.Start();
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
