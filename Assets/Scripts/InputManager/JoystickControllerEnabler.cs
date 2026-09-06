using UnityEngine;

public class JoystickControllerEnabler : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.SetActive(OptionsController.Instance.GetJoystick());
    }
}
