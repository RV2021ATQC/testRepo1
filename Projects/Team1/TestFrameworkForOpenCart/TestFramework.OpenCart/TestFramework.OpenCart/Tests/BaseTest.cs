﻿using NLog;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.OpenCart
{
    public abstract class ABaseTest
    {
        public Logger log = LogManager.GetCurrentClassLogger();
    }
    
}
