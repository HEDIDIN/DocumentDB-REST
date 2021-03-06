﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class CollectionCollection
    {
        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public static IList<Collection> DeserializeJson(JToken inputObject)
        {
            IList<Collection> deserializedObject = new List<Collection>();
            foreach (var iListValue in (JArray) inputObject)
            {
                var collection = new Collection();
                collection.DeserializeJson(iListValue);
                deserializedObject.Add(collection);
            }
            return deserializedObject;
        }
    }
}