using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashSceneManager : MonoBehaviour
{
    [SerializeField] private Animator splashScene;
    private void Start()
    {
        if (splashScene == null)
        {
            Application.Quit();
        }else
        {
            splashScene.Play("Run");
        }
        Invoke("EnableMenu", 2f);
    }
    private void EnableMenu()
    {
        SceneManager.LoadScene(1);
    }
}
