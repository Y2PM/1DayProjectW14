﻿using ADOClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceCL
{
    [ServiceContract]
    public interface IServe
    {
        [OperationContract]
        void addItemtoDBServiceMethod(Basket anItem);

    }
}
