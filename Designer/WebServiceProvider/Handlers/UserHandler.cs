using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Design.Constants;
using Design.Modules;
using Design.Session;
using Design.WebServiceProvider.DTO;
using Newtonsoft.Json;
using RestSharp;

namespace Design.WebServiceProvider.Handlers
{
    public static class UserHandler
    {
        public static async Task OnLogin(LoginRequest loginRequest, Action<LoginResponse> successCallback, Action<ResponseBase> errorCallback, IView iView, string id = null)
        {
            try
            {
                var request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddHeader(ApiHeaders.SOURCE_HDR_PARAM_KEY, ApiHeaders.SOURCE_VALUE);
                request.AddParameter(ApiHeaders.USER_NAME_PARAM_KEY, loginRequest.UserName);
                request.AddParameter(ApiHeaders.PASSWORD_PARAM_KEY, loginRequest.Password);
                request.AddParameter(ApiHeaders.DEVICE_ID_PARAM_KEY, loginRequest.DeviceID);
                request.AddParameter(ApiHeaders.DEVICE_TOKEN_PARAM_KEY, loginRequest.DeviceToken);
                request.AddParameter(ApiHeaders.OS_NAME_PARAM_KEY, loginRequest.OsName);
                request.AddParameter(ApiHeaders.OS_VERSION_PARAM_KEY, loginRequest.OsVersion);
                request.AddParameter(ApiHeaders.MODEL_NAME_PARAM_KEY, loginRequest.ModelName);

                Debug.WriteLine(JsonConvert.SerializeObject(request));
                await APIServiceProvider.Execute(request, Urls.LOGIN_URL, successCallback, errorCallback, iView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" Class Name : " + MethodBase.GetCurrentMethod().DeclaringType + "  Method Name : " + MethodBase.GetCurrentMethod().Name + "() => Error Msg : " + ex.Message);
            }
        }

        public static async Task OnChangePassword(ChangePasswordRequest changePasswordRequest, Action<ResponseBase> successCallback, Action<ResponseBase> errorCallback, IView iView, string id = null)
        {
            try
            {

                var request = new RestRequest(Method.POST);
                //request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(changePasswordRequest);
                request.AddHeader(ApiHeaders.SOURCE_HDR_PARAM_KEY, ApiHeaders.SOURCE_VALUE);
                request.AddHeader(ApiHeaders.USER_HDR_PARAM_KEY, SessionHandler.GetInstance().GetUserID().ToString());
                request.AddHeader(ApiHeaders.AUTHORIZATION_HDR_PARAM_KEY, SessionHandler.GetInstance().GetToken());

                Debug.WriteLine(JsonConvert.SerializeObject(changePasswordRequest));
                await APIServiceProvider.Execute(request, Urls.CHANGE_PWD_URL, successCallback, errorCallback, iView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" Class Name : " + MethodBase.GetCurrentMethod().DeclaringType + "  Method Name : " + MethodBase.GetCurrentMethod().Name + "() => Error Msg : " + ex.Message);
            }
        }

        public static async Task OnForgotPassword(ForgotPasswordRequest forgotPasswordRequest, Action<ResponseBase> successCallback, Action<ResponseBase> errorCallback, IView iView, string id = null)
        {
            try
            {

                var request = new RestRequest(Method.POST);
                request.AddHeader(ApiHeaders.SOURCE_HDR_PARAM_KEY, ApiHeaders.SOURCE_VALUE);
                request.AddHeader(ApiHeaders.AUTHORIZATION_HDR_PARAM_KEY, SessionHandler.GetInstance().GetToken());

                request.AddJsonBody(forgotPasswordRequest);

                Debug.WriteLine(JsonConvert.SerializeObject(forgotPasswordRequest));
                await APIServiceProvider.Execute(request, Urls.FORGOT_PWD_URL, successCallback, errorCallback, iView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(" Class Name : " + MethodBase.GetCurrentMethod().DeclaringType + "  Method Name : " + MethodBase.GetCurrentMethod().Name + "() => Error Msg : " + ex.Message);
            }
        }

        //public static async Task OnGetProjectList(Action<GetProjectListResponse> successCallback, Action<ResponseBase> errorCallback, string id = null)
        //{
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader(Constants.SOURCE_HDR_PARAM_KEY, Constants.SOURCE);
        //    request.AddHeader(Constants.AUTHORIZATION_HDR_PARAM, SessionHandler.GetInstance().GetAuthorization());

        //    await APIServiceProvider.Execute(request, Constants.GET_PROJECT_LIST_URL + "/" + SessionHandler.GetInstance().GetUserID(), successCallback, errorCallback);
        //}
    }

    public interface IUserHandler
    {
        Task OnLogin(LoginRequest loginRequest, Action<LoginResponse> successCallback, Action<ResponseBase> errorCallback, string id = null);
        Task OnChangePassword(ChangePasswordRequest changePasswordRequest, Action<ResponseBase> successCallback, Action<ResponseBase> errorCallback, string id = null);
        Task OnForgotPassword(ForgotPasswordRequest forgotPasswordRequest, Action<ResponseBase> successCallback, Action<ResponseBase> errorCallback, string id = null);
        //Task OnGetProjectList(Action<GetProjectListResponse> successCallback, Action<ResponseBase> errorCallback, string id = null);
    }
}
