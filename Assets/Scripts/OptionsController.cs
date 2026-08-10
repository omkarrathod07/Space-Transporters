using System;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public static OptionsController Instance;
    [SerializeField] private int difficultyLevel;
    [SerializeField] private GameObject pcControlInfo;
    [SerializeField] private Button pcControlButton;
    [SerializeField] private GameObject difficultyInfo;
    [SerializeField] private Button difficultyButton;
    [SerializeField] private TMP_Dropdown difficultyDropDown;
    [SerializeField] private Button applyButton;
    [SerializeField] private GameObject menuOption;
    [SerializeField] private GameObject optionMenu;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        pcControlInfo.SetActive(false);
        difficultyInfo.SetActive(false);
        pcControlButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(true);
            difficultyInfo.SetActive(false);
        });
        difficultyButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(false);
            difficultyInfo.SetActive(true);
        });
        applyButton.onClick.AddListener(() =>
        {
            SetDifficultyLevel();
            menuOption.SetActive(true);
            optionMenu.SetActive(false);
        });
        Debug.Log(difficultyDropDown);
    }

    public void SetDifficultyLevel()
    {
        difficultyLevel = difficultyDropDown.value;
        Debug.Log(GetDifficultyLevel());
    }
    public int GetDifficultyLevel()
    {
        return difficultyLevel;
    }
}