using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{

    private ContactFilter2D _filter;
    private BoxCollider2D _boxCollider;
    private Collider2D[] _hits = new Collider2D[10];
    // Start is called before the first frame update
    protected virtual void Start()
    {
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        //Collision
        _boxCollider.OverlapCollider(_filter, _hits);
        for (int i = 0; i < _hits.Length; i++)
        {
            if(_hits[i] == null)
                continue;

            OnCollide(_hits[i]);

            //clean

            _hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
}
