using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameLibrary.Services
{
    internal class StorageService
    {
        private static readonly Windows.Storage.ApplicationDataContainer LocalSettings =
            Windows.Storage.ApplicationData.Current.LocalSettings;

        private static Windows.Storage.StorageFolder _localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;

        /// <summary>
        /// Saves data into device storage
        /// </summary>
        /// <param name="key">Key value</param>
        /// <param name="data">Object to save</param>
        public static void SaveData(string key, object data)
        {
            LocalSettings.Values[key] = data;
        }

        /// <summary>
        /// Reads data that was previously saved in device
        /// </summary>
        /// <typeparam name="T">Return object type</typeparam>
        /// <param name="key">Key value</param>
        /// <param name="returnObject">Return object</param>
        /// <returns></returns>
        public static bool ReadData<T>(string key, ref T returnObject)
        {
            var obtainedData = LocalSettings.Values[key];
            if (obtainedData == null) return false;
            returnObject = (T) obtainedData;
            return true;
        }
    }
}
