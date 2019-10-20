using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Design.WebServiceProvider.DTO;
using Design.WebServiceProvider.Handlers;
using Newtonsoft.Json;

namespace Design.Modules.User.Login
{
    // Api Impl
    public class LoginViewModelImpl : ILoginViewModel
    {
        private ILoginView _iloginView;

        public LoginViewModelImpl(ILoginView view)
        {
            _iloginView = view;
        }

        public static LoginViewModelImpl GetInstance(ILoginView view)
        {
            return new LoginViewModelImpl(view);
        }

        public async Task<LoginResponse> OnLogin(LoginRequest loginRequest)
        {
            //INetworkConnectivity iNetworkConnection = new NetworkConnectivity();
            Debug.WriteLine(" LoginRequest From LoginModalImpl : " + JsonConvert.SerializeObject(loginRequest));
            LoginResponse loginResponse = new LoginResponse();
            try
            {
                //if (iNetworkConnection.HasNetworkConnection())
                //{
                //_iloginView.ShowProgressbar();
                Debug.WriteLine("Internet Connected");
                await UserHandler.OnLogin(loginRequest, (response) =>
                {
                    Debug.WriteLine("Status Code And Status Message : " + response.StatusCode + ' ' + response.Message);

                    if (response.StatusCode == 200)
                    {
                        _iloginView.DismissProgressbar();
                        _iloginView.ShowMessage(response.Message);
                        loginResponse = response;
                    }
                    else
                    {
                        _iloginView.DismissProgressbar();
                        _iloginView.ShowMessage(response.Message);
                    }
                }, (errorResponse) =>
                {
                    //_iloginView.DismissProgressbar();
                    //_iloginView.ShowMessage(errorResponse.Message);
                    //loginResponse.StatusCode = errorResponse.StatusCode;
                }, _iloginView);
                //}
                //else
                //{
                //    _iloginView.DismissProgressbar();
                //    _iloginView.ShowMessage(Constants.NO_NETWORK_CONNECTION);
                //    loginResponse.StatusCode = 1;
                //    loginResponse.Message = Constants.NO_NETWORK_CONNECTION;
                //}
            }
            catch (Exception ex)
            {
                _iloginView.DismissProgressbar();
                Debug.WriteLine(" Class Name : " + MethodBase.GetCurrentMethod().DeclaringType + "  Method Name : " + MethodBase.GetCurrentMethod().Name + "() => Error Msg : " + ex.Message);
            }
            //Debug.WriteLine("Login response From LoginMOdel IMpl :"+ JsonConvert.SerializeObject(loginResponse));
            return loginResponse;
        }
    }

    // api
    public interface ILoginViewModel
    {
        //void OnCreateModel(LoginRequest loginRequest);
        Task<LoginResponse> OnLogin(LoginRequest loginRequest);
        //void OnForgotPasswordClick();
    }

    // view
    public interface ILoginView : IView
    {
        //void OnSuccessLogin();
    }
}
