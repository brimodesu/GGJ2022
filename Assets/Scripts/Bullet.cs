using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;


    public Vector3 direction = Vector3.zero;
    public float speed;
    public bool canDestroy = false;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = direction * speed;
        if (gameObject.activeInHierarchy && !canDestroy)
        {
            canDestroy = true;
            StartCoroutine(DestroyBullet());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
            canDestroy = false;
            StopCoroutine(DestroyBullet());
        }
    }

    IEnumerator DestroyBullet()
    {
        while (gameObject.activeInHierarchy)
        {
            yield return new WaitForSeconds(5);
            gameObject.SetActive(false);
        }
    }
}
