// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Phoneword2
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton CallButton { get; set; }

		[Outlet]
		UIKit.UIButton CallHistoryButton { get; set; }

		[Outlet]
		UIKit.UITextField PhoneNumberText { get; set; }

		[Outlet]
		UIKit.UILabel PhonewordLabel { get; set; }

		[Outlet]
		UIKit.UINavigationItem PhonewordNavTitle { get; set; }

		[Outlet]
		UIKit.UIButton TranslateButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CallButton != null) {
				CallButton.Dispose ();
				CallButton = null;
			}

			if (PhoneNumberText != null) {
				PhoneNumberText.Dispose ();
				PhoneNumberText = null;
			}

			if (PhonewordLabel != null) {
				PhonewordLabel.Dispose ();
				PhonewordLabel = null;
			}

			if (TranslateButton != null) {
				TranslateButton.Dispose ();
				TranslateButton = null;
			}

			if (PhonewordNavTitle != null) {
				PhonewordNavTitle.Dispose ();
				PhonewordNavTitle = null;
			}

			if (CallHistoryButton != null) {
				CallHistoryButton.Dispose ();
				CallHistoryButton = null;
			}
		}
	}
}
