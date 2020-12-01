using System;
using MongoDB.Bson;
using MongoDB.Driver;
using AppKit;
using Foundation;

namespace Library
{ 
	public partial class ViewController : NSViewController
	{
		#region Computed Properties
		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
			}
		}
		#endregion

		#region Constructors
		public ViewController (IntPtr handle) : base (handle)
		{
		}
		#endregion

		#region Override Methods
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Set the initial value for the label
			SubmitConf.StringValue = "";
		}
		#endregion

		#region Custom Actions
		partial void ClickedButton(Foundation.NSObject sender) {
			MongoClient dbClient = new MongoClient("<REDACTED>");
			var database = dbClient.GetDatabase("testing");
			var collection = database.GetCollection<BsonDocument>("collectionlol");

			var document = new BsonDocument
			{
				{"FID", "No FID right now"},
				{"Title", TitleOut.StringValue},
				{"Author", AuthorOut.StringValue},
				{"Genre", GenreOut.StringValue},
				{"ISBN", ISBNOut.StringValue},
				{"Location", LocOut.StringValue}

			};

			collection.InsertOne(document);
			SubmitConf.StringValue = "Submitted";
		}
		#endregion
	}
}
