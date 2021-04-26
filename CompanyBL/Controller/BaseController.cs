using CompanyBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBL.Controller
{
    public abstract class BaseController
    {
        protected readonly IDataSaver manager = new DbDataSaver();
        protected CompanyContext db;
        public BaseController()
        {
            db = new CompanyContext();
        }

    }
}
