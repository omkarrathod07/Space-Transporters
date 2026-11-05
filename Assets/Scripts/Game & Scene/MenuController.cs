using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button loadButton;
    [SerializeField] private Button optionButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private int startingLevelIndex;
    [SerializeField] private GameObject menuOption;
    [SerializeField] private GameObject optionMenu;

    private void Start()
    {
        menuOption.SetActive(true);
        optionMenu.SetActive(false);
        startButton.onClick.AddListener(() =>
        {
            LoadFirstLevel(startingLevelIndex);
        });
        loadButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SaveManager.instance.GetSavedLevelIndex());
        });
        optionButton.onClick.AddListener(() =>
        {
            menuOption.SetActive(false);
            optionMenu.SetActive(true);
        });
        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }

    private void LoadFirstLevel(int index)
    {
        SaveManager.instance.SetSavedLevelIndex(index);
        SceneManager.LoadScene(index);
    }
}
