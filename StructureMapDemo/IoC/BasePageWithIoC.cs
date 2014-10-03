namespace StructureMapDemo.IoC
{
    using System;
    using System.Web.UI;

    public class BasePageWithIoC : Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            IoC.BuildUp(this);
        }
    }
}