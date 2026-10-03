using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button menuButton;
    private void Awake()
    {
        restartButton.onClick.AddListener(() =>
        {
            ImplementTime(1);
            LevelManager.Instance.RestartLevel();
        });
        pauseButton.onClick.AddListener(() =>
        {
            ImplementTime(0);
        });
        resumeButton.onClick.AddListener(() =>
        {
            ImplementTime(1);
        });
        menuButton.onClick.AddListener(() =>
        {
            ImplementTime(1);
            OptionsController.Instance.GetDesrtoy();
            LevelManager.Instance.GetDestroy();
            GameInput.Instance.GetDesrtoy();
            Invoke("GotoStartMenu", 0.5f);
        });
    }
    private void ImplementTime(int time)
    {
        Time.timeScale = time;
        if(time <= 0)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }
    private void GotoStartMenu()
    {
        MusicManager.Instance.GetDesrtoy();
        SceneManager.LoadScene(1);
    }
}