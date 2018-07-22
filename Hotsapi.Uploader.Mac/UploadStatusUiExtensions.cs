using System;
using System.Text.RegularExpressions;
using AppKit;
using Hotsapi.Uploader.Common;

namespace Hotsapi.Uploader.Mac
{
    public static class UploadStatusUiExtensions
    {
        public static string ToFormattedName(this UploadStatus status) {
            if (status == UploadStatus.None)
            {
                return "";
            }
            // Convert "EnumItems" to "Enum items"
            return Regex.Replace(status.ToString(), "([a-z])([A-Z])", m => $"{m.Groups[1].Value} {m.Groups[2].Value.ToLower()}");
        }

        public static string AggregateLabelText(this UploadStatus status)
        {
            string result = "";
            switch (status) {
                case UploadStatus.None:
                    result = "Not processed: {0}";
                    break;
                case UploadStatus.Success:
                    result = "Success: {0}";
                    break;
                case UploadStatus.UploadError:
                    result = "Upload error: {0}";
                    break;
                case UploadStatus.Duplicate:
                    result = "Duplicate: {0}";
                    break;
                case UploadStatus.AiDetected:
                    result = "Ai detected: {0}";
                    break;
                case UploadStatus.CustomGame:
                    result = "Custom game: {0}";
                    break;
                case UploadStatus.PtrRegion:
                    result = "Ptr region: {0}";
                    break;
                case UploadStatus.TooOld:
                    result = "Too old: {0}";
                    break;
                case UploadStatus.Incomplete:
                    result = "Incomplete: {0}";
                    break;
            }
            return result;
        }

        public static NSColor GetLabelColor(this UploadStatus value)
        {
            NSColor result;
            switch (value)
            {
                case UploadStatus.Success:
                    result = NSColor.Green;
                    break;
                case UploadStatus.InProgress:
                    result = NSColor.Orange;
                    break;
                case UploadStatus.Duplicate:
                case UploadStatus.AiDetected:
                case UploadStatus.CustomGame:
                case UploadStatus.PtrRegion:
                case UploadStatus.TooOld:
                    result = NSColor.Gray;
                    break;
                case UploadStatus.None:
                case UploadStatus.UploadError:
                case UploadStatus.Incomplete:
                default:
                    result = NSColor.Red;
                    break;
            }

            return result;
        }
    }
}
