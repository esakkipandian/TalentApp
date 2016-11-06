using SimpleInjector;

namespace Prft.Talent.Framework.DependencyInjection
{
    public interface IBootstrap
    {
        void Configure(Container container);
    }
}
