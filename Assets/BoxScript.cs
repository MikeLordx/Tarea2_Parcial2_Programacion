using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public Rigidbody2D _rb = default;
    public float _force = 500f;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(BoxRoutine());
    }

    IEnumerator BoxRoutine()
    {
        GetComponent<SpriteRenderer>().color = Color.magenta;
        _rb.AddForce(transform.up * _force, ForceMode2D.Force);
        yield return new WaitForSeconds(1);
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
