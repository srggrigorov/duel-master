using UnityEngine;
using Zenject;

namespace GameAssets.Scripts.Game
{
    public class Preloader : MonoBehaviour
    {
        [SerializeField] private string _mainSceneName;

        private ZenjectSceneLoader _sceneLoader;

        [Inject]
        private void Construct(InputManager inputManager, ZenjectSceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        private void Start()
        {
            _sceneLoader.LoadSceneAsync(_mainSceneName);
        }
    }
}