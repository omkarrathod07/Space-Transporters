using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager Instance;
    private static float musicTime;
    private AudioSource musicSource;

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
        musicSource = GetComponent<AudioSource>();
        musicSource.time = musicTime;
    }
    private void Update()
    {
        musicTime = musicSource.time;
    }
}
