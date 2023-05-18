using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Button button;

    [SerializeField] private float circleRadius;
    [SerializeField] private int circleDrawSteps;


    private InputAction _primaryTouchAction;

    private void Awake()
    {
        if (playerInput == null)
        {
            playerInput = GetComponent<PlayerInput>();
        }

        _primaryTouchAction = playerInput.actions["PrimaryTouch"];
        button.onClick.AddListener(() => Debug.Log("CLICK"));
        
    }

    private void OnEnable()
    {
        _primaryTouchAction.performed += PrimaryTouchPerformed;
    }

    private void OnDisable()
    {
        _primaryTouchAction.performed -= PrimaryTouchPerformed;
    }

    private void PrimaryTouchPerformed(InputAction.CallbackContext context)
    {
        Debug.Log($"{context.ReadValue<TouchState>().position}");
    }

    private void DrawCenterCircle(float radius, int steps)
    {
        Vector2 screenCenter = new Vector2(Screen.width / 2, Screen.height / 2);
    }
}