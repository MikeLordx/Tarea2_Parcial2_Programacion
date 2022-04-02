using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform _firePoint = default;
    public GameObject _bulletPrefab = default;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
    }
}
