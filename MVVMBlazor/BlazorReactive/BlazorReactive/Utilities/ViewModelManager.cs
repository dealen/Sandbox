using BlazorReactive.ViewModels;
using System.ComponentModel;

namespace BlazorReactive.Utilities
{
    public class ViewModelManager
    {
        public static T Create<T>()
        {
            var type = typeof(T).Name;

            //if (type is nameof(ILoginViewModel))
            //{
            //    return new LoginViewModel();
            //}
            //else if (type is nameof(IInfoViewModel))
            //{
            //    return new InfoViewModel();
            //}

            throw new Exception("Type not found.");
        }


    }
}
