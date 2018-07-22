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
	[Register ("SettingsController")]
	partial class SettingsController
	{
		[Outlet]
		AppKit.NSButton DeleteAiCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteBrawlCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteCustomCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteHeroLeagueCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeletePtrCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteQuickMatchCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteTeamLeagueCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton DeleteUnrakedDraftCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton MinimizeToTrayCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton StartWithMacCheckBox { get; set; }

		[Outlet]
		AppKit.NSButton UploadToHotsLogsCheckBox { get; set; }

		[Action ("DeleteAi:")]
		partial void DeleteAi (Foundation.NSObject sender);

		[Action ("DeleteBrawl:")]
		partial void DeleteBrawl (Foundation.NSObject sender);

		[Action ("DeleteCustom:")]
		partial void DeleteCustom (Foundation.NSObject sender);

		[Action ("DeleteHeroLeague:")]
		partial void DeleteHeroLeague (Foundation.NSObject sender);

		[Action ("DeletePtr:")]
		partial void DeletePtr (Foundation.NSObject sender);

		[Action ("DeleteQuickMatch:")]
		partial void DeleteQuickMatch (Foundation.NSObject sender);

		[Action ("DeleteTeamLeague:")]
		partial void DeleteTeamLeague (Foundation.NSObject sender);

		[Action ("DeleteUnrakedDraft:")]
		partial void DeleteUnrakedDraft (Foundation.NSObject sender);

		[Action ("DeleteUnrankedDraft:")]
		partial void DeleteUnrankedDraft (Foundation.NSObject sender);

		[Action ("DeltePtr:")]
		partial void DeltePtr (Foundation.NSObject sender);

		[Action ("MinimizeToTray:")]
		partial void MinimizeToTray (Foundation.NSObject sender);

		[Action ("ShowLog:")]
		partial void ShowLog (Foundation.NSObject sender);

		[Action ("StartWithMac:")]
		partial void StartWithMac (Foundation.NSObject sender);

		[Action ("UploadToHotsLogs:")]
		partial void UploadToHotsLogs (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (UploadToHotsLogsCheckBox != null) {
				UploadToHotsLogsCheckBox.Dispose ();
				UploadToHotsLogsCheckBox = null;
			}

			if (StartWithMacCheckBox != null) {
				StartWithMacCheckBox.Dispose ();
				StartWithMacCheckBox = null;
			}

			if (MinimizeToTrayCheckBox != null) {
				MinimizeToTrayCheckBox.Dispose ();
				MinimizeToTrayCheckBox = null;
			}

			if (DeletePtrCheckBox != null) {
				DeletePtrCheckBox.Dispose ();
				DeletePtrCheckBox = null;
			}

			if (DeleteAiCheckBox != null) {
				DeleteAiCheckBox.Dispose ();
				DeleteAiCheckBox = null;
			}

			if (DeleteBrawlCheckBox != null) {
				DeleteBrawlCheckBox.Dispose ();
				DeleteBrawlCheckBox = null;
			}

			if (DeleteQuickMatchCheckBox != null) {
				DeleteQuickMatchCheckBox.Dispose ();
				DeleteQuickMatchCheckBox = null;
			}

			if (DeleteUnrakedDraftCheckBox != null) {
				DeleteUnrakedDraftCheckBox.Dispose ();
				DeleteUnrakedDraftCheckBox = null;
			}

			if (DeleteTeamLeagueCheckBox != null) {
				DeleteTeamLeagueCheckBox.Dispose ();
				DeleteTeamLeagueCheckBox = null;
			}

			if (DeleteCustomCheckBox != null) {
				DeleteCustomCheckBox.Dispose ();
				DeleteCustomCheckBox = null;
			}

			if (DeleteHeroLeagueCheckBox != null) {
				DeleteHeroLeagueCheckBox.Dispose ();
				DeleteHeroLeagueCheckBox = null;
			}
		}
	}
}
