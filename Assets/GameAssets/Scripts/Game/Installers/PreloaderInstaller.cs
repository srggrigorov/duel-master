using Zenject;

namespace GameAssets.Scripts.Installers
{
    public class PreloaderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<InputManager>().AsSingle().NonLazy();
        }
    }
}