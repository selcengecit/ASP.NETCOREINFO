﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInfo.Extention
{
    public static class SessionsEttensionsMethods
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);    
          
        }

        public static T GetObject<T>(this ISession session,string key)
        {
            string objectString = session.GetString(key);
            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
