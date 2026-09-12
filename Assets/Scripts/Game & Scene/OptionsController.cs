using System;
using TMPro;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public static OptionsController Instance;
    private bool joystick;
    [Header("PC Controller")]
    [SerializeField] private GameObject pcControlInfo;
    [SerializeField] private Button pcControlButton;
    [SerializeField] private Toggle joystickToggle;
    [Header("Difficulty")]
    private int difficultyLevel;
    [SerializeField] private GameObject difficultyInfo;
    [SerializeField] private Button difficultyButton;
    [SerializeField] private TMP_Dropdown difficultyDropDown;
    [Header("Audio & Music")]
    private float music = 0;
    [SerializeField] private Button audioButton;
    [SerializeField] private GameObject audioSetting;
    [SerializeField] private Slider audioSlider;
    [SerializeField] private TextMeshProUGUI audioValue;
    [Header("Menu Button")]
    [SerializeField] private GameObject menuOption;
    [SerializeField] private GameObject optionMenu;
    [SerializeField] private Button applyButton;
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
        audioSetting.SetActive(false);
        audioSlider.value = 0.7f;
        joystickToggle.gameObject.SetActive(false);
        pcControlButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(true);
            joystickToggle.gameObject.SetActive(true);
            difficultyInfo.SetActive(false);
            audioSetting.SetActive(false);
        });
        difficultyButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(false);
            joystickToggle.gameObject.SetActive(false);
            difficultyInfo.SetActive(true);
            audioSetting.SetActive(false);
        });
        audioButton.onClick.AddListener(() =>
        {
            pcControlInfo.SetActive(false);
            joystickToggle.gameObject.SetActive(false);
            difficultyInfo.SetActive(false);
            audioSetting.SetActive(true);
        });
        applyButton.onClick.AddListener(() =>
        {
            SetDifficultyLevel();
            SetJoystick();
            SetAudio();
            menuOption.SetActive(true);
            optionMenu.SetActive(false);
        });
    }
    private void Update()
    {
        audioValue.text = Mathf.Round(audioSlider.value * 100).ToString();
    }
    private void SetAudio()
    {
        music = audioSlider.value;
        Debug.LogWarning(music);
    }

    private void SetJoystick()
    {
        joystick = joystickToggle.isOn;
    }
    private void SetDifficultyLevel()
    {
        difficultyLevel = difficultyDropDown.value;
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