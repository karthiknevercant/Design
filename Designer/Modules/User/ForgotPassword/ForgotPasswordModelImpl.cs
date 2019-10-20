using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Design.WebServiceProvider;
using Design.WebServiceProvider.DTO;
using Design.WebServiceProvider.Handlers;

namespace Design.Modules.User.ForgotPassword
{
    public class ForgotPasswordViewModelImpl : IForgotPasswordViewModel
    {
        private IForgotPasswordView _forgotPasswordView;

        public ForgotPasswordViewModelImpl(IForgotPasswordView view)
        {
            _forgotPasswordView = view;
        }

        public static ForgotPasswordViewModelImpl GetInstance(IForgotPasswordView view)
        {
            return new ForgotPasswordViewModelImpl(view);
        }

        public async Task<ResponseBase> OnForgotPassword(ForgotPasswordRequest forgotPasswordRequest)
        {
            //INetworkConnectivity iNetworkConnection = new NetworkConnectivity();
            ResponseBase fogotPswdresponse = null;
            try
            {
                //if (iNetworkConnection.HasNetworkConnection())
                //{
                _forgotPasswordView.ShowProgressbar();
                Debug.WriteLine("Internet Connected");
                await UserHandler.OnForgotPassword(forgotPasswordRequest, (response) =>
                {
                    Debug.WriteLine("Status Code And Status Message of Forgot Pswd Api " + response.StatusCode);
                    if (response.StatusCode == 200)
                    {
                        _forgotPasswordView.DismissProgressbar();
                        _forgotPasswordView.ShowMessage(response.Message);
                        fogotPswdresponse = response;
                    }
                    else
                    {
                        _forgotPasswordView.DismissProgressbar();
                        _forgotPasswordView.ShowMessage(response.Message);
                    }
                }, (errorResponse) =>
                {
                    _forgotPasswordView.DismissProgressbar();
                    _forgotPasswordView.ShowMessage(errorResponse.Message);
                }, _forgotPasswordView);
                //}
                //else
                //{
                //    _forgotPasswordView.ShowMessage(Constants.NO_NETWORK_CONNECTION);
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return fogotPswdresponse;
        }
    }

    public interface IForgotPasswordViewModel
    {
        Task<ResponseBase> OnForgotPassword(ForgotPasswordRequest forgotPasswordRequest);
    }

    public interface IForgotPasswordView : IView
    {
        //void OnPasswordChanged();
    }
}
