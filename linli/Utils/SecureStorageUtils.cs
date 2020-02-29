using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace linli.Utils
{
    public class SecureStorageUtils
    {
        public static async Task<bool> SaveAsync(string key,string value) {
            try
            {
                await SecureStorage.SetAsync(key, value);
                return true;
            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
                return false;
            }
        }
        public static async Task<string> GetAsync(string key)
        {
            try
            {
                return await SecureStorage.GetAsync(key);
            }
            catch (Exception)
            {
                // Possible that device doesn't support secure storage on device.
                return string.Empty;
            }
        }
    }
}
