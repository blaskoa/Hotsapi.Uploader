using System;

using AppKit;
using Foundation;
using Hotsapi.Uploader.Mac.Table;
using Hotsapi.Uploader.Common;
using System.Collections.Generic;

namespace Hotsapi.Uploader.Mac
{
    public partial class ViewController : NSViewController
    {
        public AppDelegate App => (AppDelegate)NSApplication.SharedApplication.Delegate;
        private Dictionary<UploadStatus, NSTextField> _aggregateLabels;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            InitializeAggregateLabels();
            base.ViewDidLoad();
            var manager = App.Manager;
            manager.Start();
            var source = new ReplayTableSource(manager.Files);
            manager.ReplayProcessed += Manager_ReplayProcessed;
            ReplaysTable.DataSource = source;
            ReplaysTable.Delegate = new ReplayTableDelegate(source);
            HandleAggregates(manager.Aggregates);
            // Do any additional setup after loading the view.
        }

        private void InitializeAggregateLabels()
        {
            _aggregateLabels = new Dictionary<UploadStatus, NSTextField> {
                { UploadStatus.None, NoneAggregateLabel },
                { UploadStatus.AiDetected, AiDetectedAggregateLabel },
                { UploadStatus.CustomGame, CustomGameAggregateLabel },
                { UploadStatus.Duplicate, DuplicateAggregateLabel },
                { UploadStatus.Incomplete, IncompleteAggregateLabel },
                { UploadStatus.TooOld, TooOldAggregateLabel },
                { UploadStatus.PtrRegion, PtrRegionAggregateLabel },
                { UploadStatus.Success, SuccessAggregateLabel },
                { UploadStatus.UploadError, UploadErrorAggregateLabel }
            };
            foreach(var label in _aggregateLabels.Values) {
                label.Hidden = true;
            }
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        void Manager_ReplayProcessed(object sender, EventArgs e)
        {
            var manager = (Manager)sender;
            InvokeOnMainThread(() => {
                ReplaysTable.ReloadData();
                StatusLabel.StringValue = manager.Status;
                HandleAggregates(manager.Aggregates);
            });
        }

        private void HandleAggregates(Dictionary<UploadStatus, int> aggregates) {
            foreach (var aggregate in aggregates) {
                if (aggregate.Key != UploadStatus.InProgress) {
                    _aggregateLabels[aggregate.Key].Hidden = false;
                    var format = aggregate.Key.AggregateLabelText();
                    _aggregateLabels[aggregate.Key].StringValue = string.Format(format, aggregate.Value);
                }
            }
        }

        partial void Settings(Foundation.NSObject sender) {
        }

        partial void ShowLog(NSObject sender)
        {
        }
    }
}
