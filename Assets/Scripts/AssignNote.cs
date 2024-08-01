using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AssignNote : MonoBehaviour
{
    public static AssignNote Instance { get; private set; }

    Timer _timer;
    KeyCheck _keyCheck;
    ScoreCounter _scoreCounter;
    FireProjectile _fireProjectile;

    public TextMeshProUGUI NoteText;

    [SerializeField] GameObject MusicBars;

    [SerializeField] float NoteSize;
    [SerializeField] int SpawnCount;
    Queue<GameObject> noteQueue = new Queue<GameObject>();

    [Header("Note Prefabs")]
    [Space]
    [SerializeField] GameObject[] NotePrefabs;
    [SerializeField] GameObject SelectedNote;

    [Header("Animators")]
    [Space]
    public Animator animatorC;
    public Animator animatorD;
    public Animator animatorE;
    public Animator animatorF;
    public Animator animatorG;
    public Animator animatorA;
    public Animator animatorB;

    [Header("Key Check")]
    [Space]
    public bool isC;
    public bool isD;
    public bool isE;
    public bool isF;
    public bool isG;
    public bool isA;
    public bool isB;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this);
        else
            Instance = this;
    }

    void Start()
    {
        _timer = Timer.Instance;
        _keyCheck = KeyCheck.Instance;
        _scoreCounter = ScoreCounter.Instance;
        _fireProjectile = FireProjectile.Instance;
        NoteText.text = "";
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            int randomIndex = Random.Range(0, NotePrefabs.Length);
            GameObject randomPrefab = NotePrefabs[randomIndex];

            SelectedNote = randomPrefab;
            SpawnNote();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ResetKeyCheck();
        }
    }

    void SpawnNote()
    {
        if (SelectedNote != null && noteQueue.Count < SpawnCount)
        {
            GameObject newNote = Instantiate(SelectedNote);
            newNote.transform.SetParent(MusicBars.transform);
            newNote.transform.localScale = new Vector3(NoteSize, NoteSize, NoteSize);

            noteQueue.Enqueue(newNote);
        }
    }

    public void DespawnNote()
    {
        if(noteQueue.Count > 0)
        {
            GameObject firstNote = noteQueue.Dequeue();
            Destroy(firstNote);
        }
    }

    public GameObject GetFirstNote()
    {
        if (noteQueue.Count > 0)
        {
            GameObject firstNote = noteQueue.Peek();

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.C)
            {
                Debug.Log("This is C");

                SetTimer();

                NoteText.text = "C";
                NoteText.color = Color.black;

                isC = true;
                animatorC.SetBool("CAssigned", true);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.D)
            {
                Debug.Log("This is D");

                SetTimer();

                NoteText.text = "D";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = true;
                animatorD.SetBool("DAssigned", true);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.E)
            {
                Debug.Log("This is E");

                SetTimer();

                NoteText.text = "E";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = true;
                animatorE.SetBool("EAssigned", true);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.F)
            {
                Debug.Log("This is F");

                SetTimer();

                NoteText.text = "F";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = true;
                animatorF.SetBool("FAssigned", true);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.G)
            {
                Debug.Log("This is G");

                SetTimer();

                NoteText.text = "G";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = true;
                animatorG.SetBool("GAssigned", true);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.A)
            {
                Debug.Log("This is A");

                SetTimer();

                NoteText.text = "A";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = true;
                animatorA.SetBool("AAssigned", true);
                isB = false;
                animatorB.SetBool("BAssigned", false);
            }

            if (firstNote.GetComponent<NoteClass>().Key == NoteKey.B)
            {
                Debug.Log("This is B");

                SetTimer();

                NoteText.text = "B";
                NoteText.color = Color.black;

                isC = false;
                animatorC.SetBool("CAssigned", false);
                isD = false;
                animatorD.SetBool("DAssigned", false);
                isE = false;
                animatorE.SetBool("EAssigned", false);
                isF = false;
                animatorF.SetBool("FAssigned", false);
                isG = false;
                animatorG.SetBool("GAssigned", false);
                isA = false;
                animatorA.SetBool("AAssigned", false);
                isB = true;
                animatorB.SetBool("BAssigned", true);
            }

            return null;
        }
        else
            return null;
    }

    void SetTimer()
    {
        _timer.currentTime = _timer.originTime + 0.1f;

        if (!_timer.isCountdown)
        {
            _timer.TimerText.color = Color.black;
            _timer.isCountdown = true;
        }
    }

    public void ResetKeyCheck()
    {
        _keyCheck.KeyGood = false;
        _keyCheck.KeyBad = false;

        _scoreCounter.canScore = true;
        _fireProjectile.canSpawn = true;

        GetFirstNote();
    }
}
