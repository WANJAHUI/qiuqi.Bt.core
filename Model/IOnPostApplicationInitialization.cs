﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt.core.Model
{
    public interface IOnPostApplicationInitialization
    {
        void OnPostApplicationInitialization(ApplicationInitializationContext context);
    }
}
