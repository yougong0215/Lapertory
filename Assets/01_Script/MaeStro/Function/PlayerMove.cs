using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimationMenu;

public class PlayerMove : MonoBehaviour
{
    [Header("������Ʈ")]
    private CharacterController _playerController;
    private PlayerAnimation _playerAnimation;

    [Header("��ġ ����")]
    public bool canMove;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _gravtiy;

    [Header("������ ���")]
    private Vector3 _moveDir;
    private float _verticalVelocity;

    [Header("�׷� �� ����")]
    public float XInput;
    public float ZInput;
    private void Awake()
    {
        canMove = true;
        _playerController = GetComponent<CharacterController>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }
    private void PlayerGravity()
    {
        if(_playerController.isGrounded == false)
        {
            _verticalVelocity = _gravtiy * Time.fixedDeltaTime;
        }
        else
        {
            _verticalVelocity = _gravtiy * 0.3f * Time.fixedDeltaTime;
        }
    }
    private void CalculatorMove()
    {
        XInput = Input.GetAxis("Horizontal");
        ZInput = Input.GetAxis("Vertical");

        _moveDir = new Vector3(XInput, 0, ZInput);

        _moveDir.Normalize();

        _moveDir *= _playerSpeed * Time.fixedDeltaTime;
        if(_moveDir.sqrMagnitude > 0)
        {
            transform.rotation = Quaternion.LookRotation(_moveDir);
        }

        if(canMove)
        {
            Vector3 move = _moveDir + _verticalVelocity * Vector3.up;
            _playerController.Move(move);
        }
    }
    private void PlayerMoveAnimation()
    {
        if(XInput != 0 || ZInput != 0)
        {
            _playerAnimation.AccesAnimation(animationMenu.Walk);
        }
        else
        {
            _playerAnimation.AccesAnimation(animationMenu.Idle);
        }
    }
    void FixedUpdate()
    {
        PlayerGravity();
        CalculatorMove();
        PlayerMoveAnimation();
    }
}
