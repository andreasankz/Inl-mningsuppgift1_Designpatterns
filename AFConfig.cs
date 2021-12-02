using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(i => i.Namespace.Contains("Observers"))
               .As(i => i.GetInterfaces()
               .FirstOrDefault(n => n.Name == "I" + i.Name))
                  .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("Program"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name))
                 .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("Subjects"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name))
                 .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
              .Where(i => i.Namespace.Contains("RepositoryData"))
              .As(i => i.GetInterfaces()
              .FirstOrDefault(n => n.Name == "I" + i.Name))
                 .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
             .Where(i => i.Namespace.Contains("Handler"))
             .As(i => i.GetInterfaces()
             .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
             .Where(i => i.Namespace.Contains("MessageType"))
             .As(i => i.GetInterfaces()
             .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
             .Where(i => i.Namespace.Contains("StrategyApp"))
             .As(i => i.GetInterfaces()
             .FirstOrDefault(n => n.Name == "I" + i.Name))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(i => i.Namespace.Contains("Data"))
            .As(i => i.GetInterfaces()
            .FirstOrDefault(n => n.Name == "I" + i.Name))
               .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(i => i.Namespace.Contains("DecoratorApp"))
            .As(i => i.GetInterfaces()
            .FirstOrDefault(n => n.Name == "I" + i.Name))
               .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .Where(i => i.Namespace.Contains("TextStyleDecorators"))
            .As(i => i.GetInterfaces()
            .FirstOrDefault(n => n.Name == "I" + i.Name))
               .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
