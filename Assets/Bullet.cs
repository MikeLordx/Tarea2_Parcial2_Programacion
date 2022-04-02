using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed = 20f;
    public Rigidbody2D _rb = default;

    void Start()
    {
        _rb.velocity = transform.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        StartCoroutine(DestroyBullet());
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
