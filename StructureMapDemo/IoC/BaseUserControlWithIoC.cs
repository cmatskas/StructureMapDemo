using System;

namespace StructureMapDemo.IoC
{
    using System.Web.UI;

    public class BaseUserControlWithIoC : UserControl
    {
        protected override void OnLoad(EventArgs e)
        {
            IoC.BuildUp(this);
            base.OnLoad(e);
        }
    }
}