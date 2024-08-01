using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[DefaultExecutionOrder(-1)]
public class Timer : MonoBehaviour
{
    public static Timer Instance { get; private set; }

    public TextMeshPro TimerText;
    public float currentTime;
    public float originTime;
    public bool isCountdown;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTime = originTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountdown)
        {
            currentTime -= 1 * Time.deltaTime;
        }
        if (currentTime <= 0)
        {
            isCountdown = false;
            currentTime = 0;
        }

        TimerText.text = currentTime.ToString("0.00");
    }
}
