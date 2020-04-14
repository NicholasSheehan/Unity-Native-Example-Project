using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityNative.ExampleProject
{
    public class BackToMainMenuUI : MonoBehaviour
    {
        public void BackToMainMenu()
        {
            SceneManager.LoadScene("Main");
            Destroy(gameObject);
        }
    }
}
