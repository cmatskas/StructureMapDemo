using System;

namespace StructureMapDemo
{
    using IoC;
    using Services;

    public partial class _Default : BasePageWithIoC
    {
        public IEmailService EmailService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var result = EmailService.SendEmail("test@test.com", "hello world");
            lblEmailResult.InnerText = "The email result was :" + (result ? "success" : "failure");
        }
    }
}