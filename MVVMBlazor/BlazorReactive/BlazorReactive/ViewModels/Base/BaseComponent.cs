using ReactiveUI;
using ReactiveUI.Blazor;

namespace BlazorReactive.ViewModels.Base
{
    public class BaseComponent<T> : ReactiveComponentBase<T>
        where T : ReactiveObject
    {
        public BaseComponent()
        {
            
        }
    }
}
