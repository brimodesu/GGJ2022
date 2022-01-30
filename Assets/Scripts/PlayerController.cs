using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    /// <summary>
    /// https://www.youtube.com/watch?v=8ZxVBCvJDWk
    /// Tutorial
    /// </summary>
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _turnSpeed = 360f;

    private Vector3 _input;

    public RangeWeaponController _rangeWeapon;
    public PlayerModelController _playerModel;
    public bool hasConcentration = true;
    

    // Update is called once per frame
    void Update()
    {
        GatherInput();
        Look();
        if (Input.GetMouseButtonDown(0) && _rangeWeapon.gameObject.activeInHierarchy && GameController.instance.playerCanShoot)
        {
            _rangeWeapon.Fire(transform);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void GatherInput()
    {
        _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (_input == Vector3.zero)
        {
            _playerModel.Animator.SetBool("Running",false);
        }
        else
        {
            _playerModel.Animator.SetBool("Running",true);
        }
    }

    void Look()
    {
        if (_input != Vector3.zero)
        {
            var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,-45,0));

            var skewedInput = matrix.MultiplyPoint3x4(_input);
            
            
            var relative = (transform.position + skewedInput) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);
            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
        }
    }

    void Move()
    {
        _rb.MovePosition(transform.position + (transform.forward * _input.normalized.magnitude) * _speed * Time.deltaTime);
        
    }
}