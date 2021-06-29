﻿using IOC;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(Web.Startup))]
namespace Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            SimpleInjectorInitializer simpleInjectorInitializer = new SimpleInjectorInitializer();
            simpleInjectorInitializer.Initialize();
        }
    }
}