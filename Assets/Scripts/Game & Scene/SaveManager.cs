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
        return PlayerPrefs.GetInt(savedLevelIndexKey, 3);
    }
    public void SetSavedLevelIndex(int levelIndex)
    {
        PlayerPrefs.SetInt(savedLevelIndexKey, levelIndex);
        PlayerPrefs.Save();
    }
    public float GetSavedAudio()
    {
        return PlayerPrefs.GetFloat(savedAudioKey, 0.5f);
    }
    public void SetSavedAudio(float audio)
    {
        PlayerPrefs.SetFloat(savedAudioKey, audio);
        PlayerPrefs.Save();
    }
    public int GetSavedDifficulty()
    {
        return PlayerPrefs.GetInt(saveDifficultyKey, 2);
    }
    public void SetSavedDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(saveDifficultyKey, difficulty);
        PlayerPrefs.Save();
    }
}