﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sfb
{
    public class Isfb
    {


    public static unsafe int IMain(string args)
        {
            CodeInject.MainMenu menu = new CodeInject.MainMenu();
            menu.ShowDialog();
    
            return 0;
        }
    }
}
