using System.Diagnostics;
using Plugin.Connectivity;

namespace Design.WebServiceProvider
{
    public class NetworkConnectivity
    {
        public static bool HasNetworkConnection()
        {
            Debug.WriteLine(CrossConnectivity.Current);

            if (CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("AvaiLable");
                return true;
            }
            else
            {
                Debug.WriteLine("Not Available");
                return false;
            }
        }
    }

    public interface INetworkConnectivity
    {
        bool HasNetworkConnection();
    }
}