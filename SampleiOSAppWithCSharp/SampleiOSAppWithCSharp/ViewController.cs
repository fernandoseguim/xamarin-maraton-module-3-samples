using System;

using UIKit;

namespace SampleiOSAppWithCSharp
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
			double Caixa, Banco, ContaCobrar, PgtoCredito, Provedores, Renda, Capital;
			btnCalcular.TouchUpInside += delegate {

				try
				{
					Caixa = double.Parse(txtCaixa.Text);
					Banco = double.Parse(txtBanco.Text);
					ContaCobrar = double.Parse(txtContaCobrar.Text);
					PgtoCredito = double.Parse(txtPgtoCredito.Text);
					Provedores = double.Parse(txtProvedores.Text);
					Renda = double.Parse(txtRenda.Text);
					Capital = (Caixa + Banco + ContaCobrar) - (PgtoCredito + Provedores + Renda);
					txtCapitalContabil.Text = Capital.ToString();


				}
				catch (Exception ex)
				{
					UIAlertView alert = new UIAlertView()
					{
						Title = "Message Error", Message = ex.Message
					};
					alert.AddButton("OK");
					alert.Show();


				}

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
