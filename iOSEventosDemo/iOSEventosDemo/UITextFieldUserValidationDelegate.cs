using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace iOSEventosDemo
{
    class UITextFieldUserValidationDelegate : UITextFieldDelegate
    {
        public override bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
        {

            return Validation.ValidateInput(replacementString,Validation.ValitationType.User);
        }
    }
}
