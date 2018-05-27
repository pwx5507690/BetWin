using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.Infrastructure
{
    public static class ExtendObject
    {
        public static string SerializeObject(this object obj, JsonSerializerSettings setting, Formatting formatting)
        {
            return JsonConvert.SerializeObject(obj, formatting, setting);
        }
        public static string SerializeObject(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static string SerializeObjectFilterNullValue(this object obj)
        {
            var setting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return SerializeObject(obj, setting, Formatting.Indented);
        }
        public static T DeserializeObject<T>(this string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }
        public static object CallMethod(this object obj, string method, params object[] param)
        {
            return obj.GetType().GetMethod(method).Invoke(obj, param);
        }
        public static T Clone<T>(this object obj)
        {
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(obj));
        }
    }
}
