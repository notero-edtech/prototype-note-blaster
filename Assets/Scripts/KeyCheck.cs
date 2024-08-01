using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour
{
    public static KeyCheck Instance { get; private set; }

    //InputManager _inputManager;
    AssignNote _assignNote;
    Timer _timer;
    ScoreCounter _scoreCounter;

    public bool KeyGood;
    public bool KeyBad;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    private void Start()
    {
        //inputManager = InputManager.instance;
        _assignNote = AssignNote.Instance;
        _timer = Timer.Instance;
        _scoreCounter = ScoreCounter.Instance;
    }

    //private void OnEnable()
    //{
    //    _inputManager.OnStartTouch += PressC;
    //    _inputManager.OnStartTouch += PressD;
    //}
    //private void OnDisable()
    //{
    //    _inputManager.OnEndTouch -= PressC;
    //    _inputManager.OnEndTouch -= PressD;
    //}

    void GoodKey()
    {
        Debug.Log("Good");

        KeyGood = true;
        KeyBad = false;

        _assignNote.NoteText.color = Color.green;
        _timer.TimerText.color = Color.green;
    }
    void BadKey()
    {
        Debug.Log("Bad");

        KeyGood = false;
        KeyBad = true;

        _assignNote.NoteText.color = Color.red;
        _timer.TimerText.color = Color.red;

        _scoreCounter.canScore = false;
    }

    public void PressC5()
    {
        _timer.isCountdown = false;

        Debug.Log("C5");
        if (_assignNote.isC)
        {
            GoodKey();
            _assignNote.animatorC.SetBool("CAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressD5()
    {
        _timer.isCountdown = false;

        Debug.Log("D5");
        if (_assignNote.isD)
        {
            GoodKey();
            _assignNote.animatorD.SetBool("DAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressE5()
    {
        _timer.isCountdown = false;

        Debug.Log("E5");
        if (_assignNote.isE)
        {
            GoodKey();
            _assignNote.animatorE.SetBool("EAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressF5()
    {
        _timer.isCountdown = false;

        Debug.Log("F5");
        if (_assignNote.isF)
        {
            GoodKey();
            _assignNote.animatorF.SetBool("FAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressG5()
    {
        _timer.isCountdown = false;

        Debug.Log("G5");
        if (_assignNote.isG)
        {
            GoodKey();
            _assignNote.animatorG.SetBool("GAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressA5()
    {
        _timer.isCountdown = false;

        Debug.Log("A5");
        if (_assignNote.isA)
        {
            GoodKey();
            _assignNote.animatorA.SetBool("AAssigned", false);
        }
        else
        {
            BadKey();
        }
    }

    public void PressB5()
    {
        _timer.isCountdown = false;

        Debug.Log("B5");
        if (_assignNote.isB)
        {
            GoodKey();
            _assignNote.animatorB.SetBool("BAssigned", false);
        }
        else
        {
            BadKey();
        }
    }
}
