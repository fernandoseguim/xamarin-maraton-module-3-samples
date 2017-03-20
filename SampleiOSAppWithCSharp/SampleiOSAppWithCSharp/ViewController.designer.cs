// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace SampleiOSAppWithCSharp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnCalcular { get; set; }

		[Outlet]
		UIKit.UITextField txtBanco { get; set; }

		[Outlet]
		UIKit.UITextField txtCaixa { get; set; }

		[Outlet]
		UIKit.UITextField txtCapitalContabil { get; set; }

		[Outlet]
		UIKit.UITextField txtContaCobrar { get; set; }

		[Outlet]
		UIKit.UITextField txtPgtoCredito { get; set; }

		[Outlet]
		UIKit.UITextField txtProvedores { get; set; }

		[Outlet]
		UIKit.UITextField txtRenda { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtCaixa != null) {
				txtCaixa.Dispose ();
				txtCaixa = null;
			}

			if (txtBanco != null) {
				txtBanco.Dispose ();
				txtBanco = null;
			}

			if (txtContaCobrar != null) {
				txtContaCobrar.Dispose ();
				txtContaCobrar = null;
			}

			if (txtPgtoCredito != null) {
				txtPgtoCredito.Dispose ();
				txtPgtoCredito = null;
			}

			if (txtProvedores != null) {
				txtProvedores.Dispose ();
				txtProvedores = null;
			}

			if (txtRenda != null) {
				txtRenda.Dispose ();
				txtRenda = null;
			}

			if (txtCapitalContabil != null) {
				txtCapitalContabil.Dispose ();
				txtCapitalContabil = null;
			}

			if (btnCalcular != null) {
				btnCalcular.Dispose ();
				btnCalcular = null;
			}
		}
	}
}
