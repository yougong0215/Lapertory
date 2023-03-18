using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimationMenu;

public class PlayerMove : MonoBehaviour
{
    [Header("컴포넌트")]
    private CharacterController _playerController;
    //private AnimationSelecter _animationSelecter;

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
        //_animationSelecter = GetComponent<AnimationSelecter>();
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
            AnimationSelecter.animationSelecter.AccesAnimation(animationMenu.Walk);
        }
        else
        {
            AnimationSelecter.animationSelecter.UnLockAnimation(animationMenu.Walk);
        }
    }
    void FixedUpdate()
    {
        PlayerGravity();
        CalculatorMove();
        PlayerMoveAnimation();
    }
}
