using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance;
     private LanderAction inputAction;
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
        inputAction = new LanderAction();
        inputAction.Enable();
    }
    private void OnDestroy()
    {
        inputAction.Disable();
    }
    public bool IsUpActionPressed()
    {
        return inputAction.Lander.Up.IsPressed();
    }
    public bool IsLeftActionPressed()
    {
        return inputAction.Lander.Left.IsPressed();
    }
    public bool IsRightActionPressed()
    {
        return inputAction.Lander.Right.IsPressed();
    }
    public Vector2 GetMovementInput()
    {
        return inputAction.Lander.Movement.ReadValue<Vector2>();
    }
    public void GetDesrtoy()
    {
        Destroy(gameObject);
    }
}
