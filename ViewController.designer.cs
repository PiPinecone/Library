// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Library
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField AuthorOut { get; set; }

		[Outlet]
		AppKit.NSTextField GenreOut { get; set; }

		[Outlet]
		AppKit.NSTextField ISBNOut { get; set; }

		[Outlet]
		AppKit.NSTextField LocOut { get; set; }

		[Outlet]
		AppKit.NSTextField SubmitConf { get; set; }

		[Outlet]
		AppKit.NSTextField TitleOut { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);

		[Action ("InputAuthor:")]
		partial void InputAuthor (Foundation.NSObject sender);

		[Action ("InputGenre:")]
		partial void InputGenre (Foundation.NSObject sender);

		[Action ("InputISBN:")]
		partial void InputISBN (Foundation.NSObject sender);

		[Action ("InputLocation:")]
		partial void InputLocation (Foundation.NSObject sender);

		[Action ("SubmitButton:")]
		partial void SubmitButton (Foundation.NSObject sender);

		[Action ("TitleInput:")]
		partial void TitleInput (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (AuthorOut != null) {
				AuthorOut.Dispose ();
				AuthorOut = null;
			}

			if (GenreOut != null) {
				GenreOut.Dispose ();
				GenreOut = null;
			}

			if (ISBNOut != null) {
				ISBNOut.Dispose ();
				ISBNOut = null;
			}

			if (LocOut != null) {
				LocOut.Dispose ();
				LocOut = null;
			}

			if (TitleOut != null) {
				TitleOut.Dispose ();
				TitleOut = null;
			}

			if (SubmitConf != null) {
				SubmitConf.Dispose ();
				SubmitConf = null;
			}
		}
	}
}
