using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public GameObject hitFX;
    private void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        //Failsafe Destroy
        Destroy(this.gameObject, 10f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        var fx = Instantiate(hitFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        Destroy(fx, .5f);
    }
}
