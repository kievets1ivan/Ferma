﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace DAL.DI
{
    public class NinjectConfig : NinjectModule
    {

        public override void Load()
        {
            Bind<IFermaRepository>().To<FermaRepository>();
        }

    }
}
