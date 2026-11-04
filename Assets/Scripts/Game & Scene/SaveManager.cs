using System;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    private int savedLevelIndex;
    private const string savedLevelIndexKey = "SavedLevelIndex";
    private float savedAudio;
    private const string savedAudioKey = "SavedAudio";
    private int saveDifficulty;
    private const string saveDifficultyKey = "SaveDifficulty";
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        LoadSaveData();
    }

    private void LoadSaveData()
    {
        savedLevelIndex = PlayerPrefs.GetInt(savedLevelIndexKey, 3);
        saveDifficulty = PlayerPrefs.GetInt(saveDifficultyKey, 2);
        savedAudio = PlayerPrefs.GetFloat(savedAudioKey, 0.5f);
    }

    public int GetSavedLevelIndex()
    {
        return savedLevelIndex;
    }
    public void SetSavedLevelIndex(int levelIndex)
    {
        PlayerPrefs.SetInt(savedLevelIndexKey, levelIndex);
    }
    public float GetSavedAudio()
    {
        return savedAudio;
    }
    public void SetSavedAudio(float audio)
    {
        PlayerPrefs.SetFloat(savedAudioKey, audio);
    }
    public int GetSavedDifficulty()
    {
        return saveDifficulty;
    }
    public void SetSavedDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(saveDifficultyKey, difficulty);
    }
}