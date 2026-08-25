using System;
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
            OptionsController.Instance.GetDesrtoy();
            LevelManager.Instance.GetDestroy();
            Invoke("GotoStartMenu", 2f);
        });
    }

    private void GotoStartMenu()
    {
        SceneManager.LoadScene(1);
    }
}
