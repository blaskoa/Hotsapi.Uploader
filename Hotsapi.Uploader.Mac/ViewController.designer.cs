// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Hotsapi.Uploader.Mac
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField AiDetectedAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField CustomGameAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField DuplicateAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField IncompleteAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTableColumn NameColumn { get; set; }

        [Outlet]
        AppKit.NSTextField NoneAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField PtrRegionAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTableView ReplaysTable { get; set; }

        [Outlet]
        AppKit.NSTableColumn StatusColumn { get; set; }

        [Outlet]
        AppKit.NSTextField StatusLabel { get; set; }

        [Outlet]
        AppKit.NSTextField SuccessAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField TooOldAggregateLabel { get; set; }

        [Outlet]
        AppKit.NSTextField UploadErrorAggregateLabel { get; set; }

        [Action ("RefreshData:")]
        partial void RefreshData (Foundation.NSObject sender);

        [Action ("Settings:")]
        partial void Settings (Foundation.NSObject sender);

        [Action ("ShowLog:")]
        partial void ShowLog (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (NameColumn != null) {
                NameColumn.Dispose ();
                NameColumn = null;
            }

            if (ReplaysTable != null) {
                ReplaysTable.Dispose ();
                ReplaysTable = null;
            }

            if (StatusColumn != null) {
                StatusColumn.Dispose ();
                StatusColumn = null;
            }

            if (StatusLabel != null) {
                StatusLabel.Dispose ();
                StatusLabel = null;
            }

            if (NoneAggregateLabel != null) {
                NoneAggregateLabel.Dispose ();
                NoneAggregateLabel = null;
            }

            if (SuccessAggregateLabel != null) {
                SuccessAggregateLabel.Dispose ();
                SuccessAggregateLabel = null;
            }

            if (UploadErrorAggregateLabel != null) {
                UploadErrorAggregateLabel.Dispose ();
                UploadErrorAggregateLabel = null;
            }

            if (DuplicateAggregateLabel != null) {
                DuplicateAggregateLabel.Dispose ();
                DuplicateAggregateLabel = null;
            }

            if (AiDetectedAggregateLabel != null) {
                AiDetectedAggregateLabel.Dispose ();
                AiDetectedAggregateLabel = null;
            }

            if (CustomGameAggregateLabel != null) {
                CustomGameAggregateLabel.Dispose ();
                CustomGameAggregateLabel = null;
            }

            if (PtrRegionAggregateLabel != null) {
                PtrRegionAggregateLabel.Dispose ();
                PtrRegionAggregateLabel = null;
            }

            if (TooOldAggregateLabel != null) {
                TooOldAggregateLabel.Dispose ();
                TooOldAggregateLabel = null;
            }

            if (IncompleteAggregateLabel != null) {
                IncompleteAggregateLabel.Dispose ();
                IncompleteAggregateLabel = null;
            }
        }
    }
}
