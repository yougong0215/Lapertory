using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ActionMenu;

public class PlayerMove : MonoBehaviour
{
    [Header("컴포넌트")]
    private CharacterController _playerController;

    [Header("수치 조정")]
    public bool canMove;
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _gravtiy;
    [SerializeField] private float _turnningSpeed;

    [Header("움직임 기능")]
    private Vector3 _moveDir;
    private float _verticalVelocity;

    float XInput;
    float ZInput;
    private void Awake()
    {
        canMove = true;
        _playerController = GetComponent<CharacterController>();
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
            transform.rotation = Quaternion.Slerp(transform.rotation, 
                                                  Quaternion.LookRotation(_moveDir), 
                                                  Time.fixedDeltaTime * _turnningSpeed);
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
            AnimationSelecter.animationSelecter.AccesAnimation(AnimationMenu.Walk);
        }
        else
        {
            AnimationSelecter.animationSelecter.AccesAnimation(AnimationMenu.Idle);
        }
    }
    void FixedUpdate()
    {
        PlayerGravity();
        CalculatorMove();
        PlayerMoveAnimation();
    }
}
