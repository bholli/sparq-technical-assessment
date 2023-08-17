using sparq_technical_assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparq_technical_assessment
{
    // Do not change the name of this class
    public class StringMap<TValue>
    {
        //collection to store <key, value> pairs
        private Dictionary<string, TValue> _map = new Dictionary<string, TValue>();

        /// <summary> Returns number of elements in a map</summary>
        public int Count => _map.Count;

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        // Do not change this property
        public TValue DefaultValue { get; set; }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in a map, then the value associated with this key should be overriden.
        /// </summary>
        /// <returns>true if the value for the key was overriden otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        public bool AddElement(string key, TValue value)
        {
            if (key == String.Empty) { 
              throw new ArgumentException("key is empty");
            }

            try
            {
                if (_map.ContainsKey(key))
                {
                    _map[key] = value;
                    return true;
                }
                else
                {
                    _map.Add(key, value);
                    return false;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("key/value is null");
                throw e;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("key is empty");
                throw e;
            }
        }

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        public bool RemoveElement(string key)
        {
            try
            {
                if (_map.ContainsKey(key))
                {
                    _map.Remove(key);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("key is null");
                throw e;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("key is empty");
                throw e;
            }
        }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            try
            {
                if (_map.ContainsKey(key))
                {
                    return _map[key];
                }
                else
                {
                    return DefaultValue;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("key is null");
                throw e;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("key is empty");
                throw e;
            }
        }

    }
}
