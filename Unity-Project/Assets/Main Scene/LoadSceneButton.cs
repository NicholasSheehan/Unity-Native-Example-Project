using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityNative.ExampleProject
{
    public class LoadSceneButton : MonoBehaviour
    {
        /// <summary>
        /// UI to spawn to enable navigation back to the main menu from another scene
        /// </summary>
        [SerializeField]
        private BackToMainMenuUI backToMainMenuUI = null;

        /// <summary>
        /// Name of the scene to load
        /// </summary>
        [SerializeField]
        private string sceneName = null;

        public void LoadScene()
        {
            var ui = Instantiate(backToMainMenuUI);
            DontDestroyOnLoad(ui);

            SceneManager.LoadScene(sceneName);
        }
    }
}
