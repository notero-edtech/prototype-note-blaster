using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool canMove;

    FireProjectile _fp;
    AssignNote _assignNote;

    // Start is called before the first frame update
    void Start()
    {
        _fp = FireProjectile.Instance;
        _assignNote = AssignNote.Instance;
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_fp.TargetPos != null && canMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _fp.TargetPos, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        canMove = false;
        _fp.canShoot = true;
        _assignNote.ResetKeyCheck();
        Destroy(gameObject);
    }
}
