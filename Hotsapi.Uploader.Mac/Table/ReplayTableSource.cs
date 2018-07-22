using System;
using AppKit;
using Hotsapi.Uploader.Common;

namespace Hotsapi.Uploader.Mac.Table
{
    public class ReplayTableSource : NSTableViewDataSource
    {
        public ObservableCollectionEx<ReplayFile> Files { get; private set; }

        public ReplayTableSource(ObservableCollectionEx<ReplayFile> files)
        {
            Files = files;
        }

        public override nint GetRowCount(NSTableView tableView)
        {
            return Files.Count;
        }
    }
}
