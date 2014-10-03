namespace StructureMapDemo.IoC
{
    using StructureMap;

    public static class IoC
    {
        private static readonly IContainer Container;

        static IoC()
        {
            Container = new Container(new ScanningRegistry());
        }

        public static T Resolve<T>()
        {
            return Container.GetInstance<T>();
        }

        public static T Resolve<T>(string name)
        {
            return Container.GetInstance<T>(name);
        }

        public static void BuildUp(object target)
        {
            Container.BuildUp(target);
        }

        public static string WhatDoIHave()
        {
            return Container.WhatDoIHave();
        }
    }
}