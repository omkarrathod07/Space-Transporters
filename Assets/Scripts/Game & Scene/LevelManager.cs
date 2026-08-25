using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int currentLevel;
    [SerializeField] private int startingLevelIndex;
    public static LevelManager Instance;

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
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(startingLevelIndex);
    }
    public void NextLevel()
    {
        startingLevelIndex++;
        currentLevel++;
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
