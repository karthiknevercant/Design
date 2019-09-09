using System;

namespace Design.Modules
{
    public interface IView
    {
        void ShowMessage(String message);
        void ShowProgressbar();
        void DismissProgressbar();
        //bool HasNetworkConnection();
    }
}