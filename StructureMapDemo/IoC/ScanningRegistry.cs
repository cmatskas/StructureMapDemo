namespace StructureMapDemo.IoC
{
    using Services;
    using StructureMap.Configuration.DSL;

    public class ScanningRegistry : Registry
    {
        public ScanningRegistry()
        {
            // Usually from web.config, but hardcoded here for simplicity
            var databaseConnectionString = "testconnectionstring";

            For<IEmailService>().Use<EmailService>().Ctor<string>("connectionString").Is(databaseConnectionString);


            Policies.SetAllProperties(y => y.WithAnyTypeFromNamespaceContainingType<EmailService>());
        }
    }
}