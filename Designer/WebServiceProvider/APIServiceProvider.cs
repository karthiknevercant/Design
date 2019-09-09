using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Design.Modules;
using RestSharp;

namespace Design.WebServiceProvider
{
    public static class APIServiceProvider
    {
        public static async Task Execute<T>(RestRequest request, string url, Action<T> successCallback, Action<ResponseBase> errorCallback, IView iView, bool useLocalData = false) where T : new()
        {
            try
            {
                //INetworkConnectivity iNetworkConnectivity = new NetworkConnectivity();

                if (NetworkConnectivity.HasNetworkConnection())
                {
                    iView.ShowProgressbar();

                    var client = new RestClient(url);

                    var response = await client.ExecuteTaskAsync<T>(request);

                    iView.DismissProgressbar();

                    if (response != null && response.StatusCode.Equals(StatusCodes.SUCCESS_STATUS_CODE))
                    {
                        successCallback?.Invoke(response.Data);
                    }
                    else
                    {
                        iView.ShowMessage(response.ErrorMessage);
                    }
                }
                else
                {
                    iView.ShowMessage(AlertMessages.NO_NETWORK_CONNECTION);
                }
            }
            catch (Exception ex)
            {
                iView.ShowMessage(ex.Message);

                //string message = string.Empty;
                //if (null != ex.Message)
                //{
                //    int.TryParse(ex.Message.Substring(0, 3), out code);
                //    message = ex.Message.Substring(3);
                //}

                //errorCallback?.Invoke(new ResponseBase { StatusCode = 0, Message = ex.Message });

                Debug.WriteLine(" Class Name : " + MethodBase.GetCurrentMethod().DeclaringType + "  Method Name : " + MethodBase.GetCurrentMethod().Name + "() => Error Msg : " + ex.Message);
            }
        }
    }
}