using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip fuelPickupAudio;
    [SerializeField] private AudioClip coinPickupAudio;
    [SerializeField] private AudioClip crashAudio;
    [SerializeField] private AudioClip LandedSuccessfulyAudio;
    private void Start()
    {
        Lander.Instance.onFuelPickup += Lander_onFuelPickup;
        Lander.Instance.onCoinPickup += Lander_onCoinPickup;
        Lander.Instance.onLanded += Lander_onLanded;
    }

    private void Lander_onLanded(object sender, Assets.Scripts.onLandedEventArgs e)
    {
        switch (e.landingType)
        {
            case Lander.LandingType.Success:
            {
                AudioSource.PlayClipAtPoint(LandedSuccessfulyAudio, Camera.main.transform.position);
                break;
            }
            default:
            {
                AudioSource.PlayClipAtPoint(crashAudio, Camera.main.transform.position);
                break;
            }
        }
    }

    private void Lander_onCoinPickup(object sender, System.EventArgs e)
    {
        AudioSource.PlayClipAtPoint(coinPickupAudio, Camera.main.transform.position);
    }

    private void Lander_onFuelPickup(object sender, System.EventArgs e)
    {
        AudioSource.PlayClipAtPoint(fuelPickupAudio, Camera.main.transform.position);
    }
}