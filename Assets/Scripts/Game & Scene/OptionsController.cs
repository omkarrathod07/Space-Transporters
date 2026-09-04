using System;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public static OptionsController Instance;
    private bool joystick;
    [SerializeField] private int difficultyLevel;
    [SerializeField] private GameObject pcControlInfo;
    [SerializeField] private Button pcControlButton;
    [SerializeField] private GameObject difficultyInfo;
    [SerializeField] private Button difficultyButton;
    [SerializeField] private TMP_Dropdown difficultyDropDown;
    [SerializeField] private Toggle joystickToggle;
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
        if(Application.platform == RuntimePlatform.WindowsPlayer)
        {
            joystickToggle.interactable = true;
            joystickToggle.isOn = false;
        }
        pcControlInfo.SetActive(false);
        difficultyInfo.SetActive(false);
        joystickToggle.gameObject.SetActive(false);
        pcControlButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(true);
            joystickToggle.gameObject.SetActive(true);
            difficultyInfo.SetActive(false);
        });
        difficultyButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(false);
            joystickToggle.gameObject.SetActive(false);
            difficultyInfo.SetActive(true);
        });
        applyButton.onClick.AddListener(() =>
        {
            SetDifficultyLevel();
            SetJoystick();
            menuOption.SetActive(true);
            optionMenu.SetActive(false);
        });
    }
    private void SetJoystick()
    {
        joystick = joystickToggle.isOn;
        Debug.Log(joystick);
    }
    private void SetDifficultyLevel()
    {
        difficultyLevel = difficultyDropDown.value;
        Debug.Log(GetDifficultyLevel());
    }
    public int GetDifficultyLevel()
    {
        return difficultyLevel;
    }
    public bool GetJoystick()
    {
        return joystick;
    }
    public void GetDesrtoy()
    {
        Destroy(gameObject);
    }
}