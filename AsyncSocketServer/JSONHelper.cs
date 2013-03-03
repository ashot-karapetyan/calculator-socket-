using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using System;

public class JSONHelper
{
    public static string To<T>(T obj)
    {
        System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType());
        string retVal = null;
        using (MemoryStream ms = new MemoryStream())
        {
            serializer.WriteObject(ms, obj);
            retVal = Encoding.Default.GetString(ms.ToArray());
        }
        return retVal;
    }

    public static T From<T>(string json)
    {
        T obj = Activator.CreateInstance<T>();
        using (MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
        }

        return obj;
    }
}