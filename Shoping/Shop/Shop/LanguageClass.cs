using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop
{
   public class LanguageClass
    {

        public static void SetKeyboardLanguage(string CultureName)
        {
            System.Globalization.CultureInfo MyLang = new System.Globalization.CultureInfo(CultureName);
            InputLanguage InLang = InputLanguage.FromCulture(MyLang);
            InputLanguage.CurrentInputLanguage = InLang;
        }

    }
}
