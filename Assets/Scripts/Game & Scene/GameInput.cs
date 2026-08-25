using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance;
     private LanderAction inputAction;
    private void Awake()
    {
        Instance = this;
        inputAction = new LanderAction();
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
}
