using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static float musicTime;
    private AudioSource musicSource;
    
    private void Awake()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.time = musicTime;
    }
    private void Update()
    {
        musicTime = musicSource.time;
    }
}
