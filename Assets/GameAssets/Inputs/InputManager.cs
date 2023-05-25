using System;
using UnityEngine.InputSystem;

public class InputManager : IDisposable
{
    private TouchControls _touchControls;

    public event Action<InputAction.CallbackContext> OnTouchStarted;
    public event Action<InputAction.CallbackContext> OnTouchPerformed;
    public event Action<InputAction.CallbackContext> OnTouchCanceled;


    public InputManager()
    {
        _touchControls = new TouchControls();
        _touchControls.Enable();

        _touchControls.Touch.TouchInput.started += TouchInputStarted;
        _touchControls.Touch.TouchInput.performed += TouchInputPerformed;
        _touchControls.Touch.TouchInput.canceled += TouchInputCanceled;
    }

    private void TouchInputCanceled(InputAction.CallbackContext callbackContext) =>
        OnTouchCanceled?.Invoke(callbackContext);

    private void TouchInputPerformed(InputAction.CallbackContext callbackContext) =>
        OnTouchPerformed?.Invoke(callbackContext);

    private void TouchInputStarted(InputAction.CallbackContext callbackContext) =>
        OnTouchStarted?.Invoke(callbackContext);

    public void Dispose()
    {
        if (_touchControls != null)
        {
            _touchControls.Disable();
            _touchControls.Touch.TouchInput.started -= TouchInputStarted;
            _touchControls.Touch.TouchInput.performed -= TouchInputPerformed;
            _touchControls.Touch.TouchInput.canceled -= TouchInputCanceled;
            _touchControls.Dispose();
        }
    }
}