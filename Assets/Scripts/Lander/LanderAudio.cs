using UnityEngine;

public class LanderAudio : MonoBehaviour
{
    [SerializeField] private AudioSource thrusterAudioSource;
    private Lander lander;

    private void Awake()
    {
        lander = GetComponent<Lander>();
    }
    private void Start()
    {
        lander.onBeforeForce += Lander_onBeforeForce;
        lander.onUpForce += Lander_onUpForce;
        lander.onLeftForce += Lander_onLeftForce;
        lander.onRightForce += Lander_onRightForce;
        thrusterAudioSource.Pause();
    }

    private void Lander_onRightForce(object sender, System.EventArgs e)
    {
        if (!thrusterAudioSource.isPlaying)
        {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_onLeftForce(object sender, System.EventArgs e)
    {
        if (!thrusterAudioSource.isPlaying)
        {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_onUpForce(object sender, System.EventArgs e)
    {
        if (!thrusterAudioSource.isPlaying)
        {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_onBeforeForce(object sender, System.EventArgs e)
    {
        thrusterAudioSource.Pause();
    }
}