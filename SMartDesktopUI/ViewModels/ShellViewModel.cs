﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SMartDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly LoginViewModel _loginVM;

        public ShellViewModel(LoginViewModel loginVM)
        {
            _loginVM = loginVM;
            ActivateItem(_loginVM);
        }
    }
}
