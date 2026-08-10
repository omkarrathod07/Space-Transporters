using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCompleteManager : MonoBehaviour
{
    [SerializeField] private Button menuButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
    }
}
