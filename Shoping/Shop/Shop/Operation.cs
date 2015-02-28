﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DevComponents.DotNetBar;
using System.Windows.Forms;
namespace Shop
{
    public   class Operation
    {

      
        public static void BeginOperation(Control frm)
        {
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = false;
                frm.Cursor = Cursors.WaitCursor;

            });
        }

        public static void EndOperation(Control frm)
        {
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = true;
                frm.Cursor = Cursors.Default;

            });
        }

      
    }
}
