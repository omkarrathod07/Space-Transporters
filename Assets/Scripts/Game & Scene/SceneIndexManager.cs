using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class SceneIndexManager : MonoBehaviour
{
    [SerializeField] private int currentLevel;
    [SerializeField] private int startingLevelIndex;
    public static SceneIndexManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        startingLevelIndex = SaveManager.instance.GetSavedLevelIndex();
        currentLevel = startingLevelIndex;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(startingLevelIndex);
    }
    public void NextLevel()
    {
        startingLevelIndex++;
        currentLevel = startingLevelIndex - 1;
        SaveManager.instance.SetSavedLevelIndex(startingLevelIndex);
        SceneManager.LoadScene(startingLevelIndex);
    }
    public int GetCurrentLevel()
    {
        return currentLevel;
    }
    public void GetDestroy()
    {
        Destroy(gameObject);
    }
}