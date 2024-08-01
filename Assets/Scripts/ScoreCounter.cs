using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance {  get; private set; }

    [SerializeField] TextMeshProUGUI ScoreText;
    public float currentScore;
    public bool canScore;

    Timer _timer;
    KeyCheck _keyCheck;
    AssignNote _assignNote;

    [Header("Score Settings")]
    [Space]
    [SerializeField] float PerfectThreshold;
    [SerializeField] float GoodThreshold;
    [SerializeField] float OkayThreshold;
    [Space]
    [SerializeField] float PerfectScore;
    [SerializeField] float GoodScore;
    [SerializeField] float OkayScore;

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
        _timer = Timer.Instance;
        _keyCheck = KeyCheck.Instance;
        _assignNote = AssignNote.Instance;
        ScoreText.text = currentScore.ToString();
        canScore = true;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = currentScore.ToString();

        if (_keyCheck.KeyGood && canScore)
        {
            Debug.Log("KeyGood");
            if (_timer.currentTime >= PerfectThreshold * _timer.originTime)
            {
                Debug.Log(PerfectThreshold);
                currentScore += PerfectScore;
                canScore = false;
            }

            if (_timer.currentTime >= GoodThreshold * _timer.originTime)
            {
                Debug.Log(GoodThreshold);
                currentScore += GoodScore;
                canScore = false;
            }

            if (_timer.currentTime >= OkayThreshold * _timer.originTime)
            {
                Debug.Log(OkayThreshold);
                currentScore += OkayScore;
                canScore = false;
            }

            _assignNote.DespawnNote();
        }
        else if (_keyCheck.KeyBad)
        {
            _assignNote.DespawnNote();
            _assignNote.ResetKeyCheck();
        }
    }
}
