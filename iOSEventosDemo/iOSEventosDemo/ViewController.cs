using System;

using UIKit;

namespace iOSEventosDemo
{
	public partial class ViewController : UIViewController
	{
		
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			btnStart.AccessibilityIdentifier = "myButton";
			btnStart.TouchUpInside += BtnStart_TouchUpInside;
			
		}

		partial void ValueChanged(UITextField sender)
		{
			if(!string.IsNullOrEmpty(txtUser.Text))
				txtPass.Enabled = true;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void BtnStart_TouchUpInside(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text))
			{
				txtCode.Enabled = true;
				string title = "Alert Popup!";
				string message = "Hello world, ";
				message += txtUser.Text;
				btnStart.TouchUpInside -= BtnStart_TouchUpInside;
				btnStart.TouchUpInside += (sen, eve) => this.ShowPopup(message, title);
			}
		}
	}
}
