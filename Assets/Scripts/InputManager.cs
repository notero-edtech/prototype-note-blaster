using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : MonoBehaviour
{
    public static InputManager instance { get; private set; }

    KeyboardControl keyboardControl;

    //public delegate void StartTouchEvt();
    //public event StartTouchEvt OnStartTouch;
    //public delegate void EndTouchEvt();
    //public event EndTouchEvt OnEndTouch;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this);
        else
            instance = this;

        keyboardControl = new KeyboardControl();
    }

    private void OnEnable()
    {
        keyboardControl.Enable();
    }
    private void OnDisable()
    {
        keyboardControl.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        keyboardControl.Touch.Key.started += ctx => StartTouch(ctx);
        keyboardControl.Touch.Key.canceled += ctx => EndTouch(ctx);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("yay");
    }

    void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("nay");
    }
}
