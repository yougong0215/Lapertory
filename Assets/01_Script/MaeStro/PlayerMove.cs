using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _gravtiy;

    private CharacterController _playerController;
    private Vector3 _moveDir;

    float XInput;
    float ZInput;
    private void Awake()
    {
        _playerController = GetComponent<CharacterController>();
    }
    private void PlayerMovement()
    {
        XInput = Input.GetAxis("Horizontal");
        ZInput = Input.GetAxis("Vertical");

        _moveDir = new Vector3(XInput, 0, ZInput) * _playerSpeed;

        _playerController.Move(_moveDir * Time.deltaTime);
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }
}
