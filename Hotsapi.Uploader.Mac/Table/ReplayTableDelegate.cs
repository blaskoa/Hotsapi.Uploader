using System;
using System.IO;
using AppKit;

namespace Hotsapi.Uploader.Mac.Table
{
    public class ReplayTableDelegate : NSTableViewDelegate
    {
        private readonly ReplayTableSource _replayTableSource;

        private const string CellIdentifier = "ReplCell";

        public ReplayTableDelegate(ReplayTableSource source)
        {
            _replayTableSource = source;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
                view.TextColor = NSColor.ControlText;
            }

            var replayFile = _replayTableSource.Files[(int)row];

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Name":
                    view.StringValue = Path.GetFileName(replayFile.Filename);
                    break;
                case "Status":
                    view.StringValue = replayFile.UploadStatus.ToFormattedName();
                    view.TextColor = replayFile.UploadStatus.GetLabelColor();
                    break;
            }

            return view;
        }
    }
}
