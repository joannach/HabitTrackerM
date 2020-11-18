using Autofac;
using HabitTracker.Server.Contract.Database;
using HabitTracker.Server.Database;

namespace HabitTracker.Server
{
    public class HabitTrackerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HabitDao>().As<IHabitDao>().SingleInstance();
            builder.RegisterType<HabitService>().As<IHabitService>().SingleInstance();

            builder.RegisterType<HabitRestServiceArgs>();
            builder.RegisterType<HabitRestService>();

        }
    }
}
