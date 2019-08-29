﻿namespace Klarna.Rest.Net.Serialization
{
    /// <summary>
    /// Interface describing the JsonSerializer used by the REST Client for serialization of API payload. 
    /// </summary>
    public interface IJsonSerializer
    {
        /// <summary>
        /// Should serialize the input object to json data
        /// </summary>
        /// <param name="item">The object to serialize</param>
        /// <returns></returns>
        string Serialize(object item);
        /// <summary>
        /// Should deserialize the json data to object of type T.
        /// </summary>
        /// <typeparam name="T">Objec Type to deserialize into</typeparam>
        /// <param name="json">Json data to deserialize</param>
        /// <returns></returns>
        T Deserialize<T>(string json);
    }
}