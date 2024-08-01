using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public static FireProjectile Instance { get; private set; }

    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject fireTarget;
    public Vector3 TargetPos;

    [SerializeField] Transform OriginPos;

    AssignNote _assignNote;
    KeyCheck _keyCheck;

    public bool canShoot;
    public bool canSpawn;

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
        _assignNote = AssignNote.Instance;
        _keyCheck = KeyCheck.Instance;
        canShoot = true;
        canSpawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (fireTarget != null && _keyCheck.KeyGood)
        {
            TargetPos = fireTarget.transform.position;
            if(canShoot && canSpawn)
            {
                canSpawn = false;
                Instantiate(Projectile, OriginPos.position, Quaternion.identity);
                canShoot = false;
            }
        }

        if(_assignNote != null)
        {
            if (_assignNote.isC)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetC");
            }

            if (_assignNote.isD)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetD");
            }

            if (_assignNote.isE)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetE");
            }

            if (_assignNote.isF)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetF");
            }

            if (_assignNote.isG)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetG");
            }

            if (_assignNote.isA)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetA");
            }

            if (_assignNote.isB)
            {
                fireTarget = GameObject.FindGameObjectWithTag("TargetB");
            }
        }
    }
}
