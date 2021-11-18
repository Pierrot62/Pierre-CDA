﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_de_produits

{
    static class ObjectHelper
    {
        public static void Dump(this object data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            Trace.WriteLine(json);
        }
    }
}
