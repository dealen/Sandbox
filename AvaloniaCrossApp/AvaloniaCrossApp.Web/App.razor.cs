using Avalonia.Web.Blazor;

namespace AvaloniaCrossApp.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaCrossApp.App>()
            .SetupWithSingleViewLifetime();
    }
}