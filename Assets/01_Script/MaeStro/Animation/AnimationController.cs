using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AnimationController : MonoBehaviour
{
    Animator _playerAnimatior;
    PlayerAnimation _playerAnimation;
    private string currentAnimation;
    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
        _playerAnimatior = GetComponent<Animator>();
    }
    
    public void SettingAnimation(string animation)
    {
        _playerAnimatior?.SetBool(currentAnimation, false);
        currentAnimation = animation;
        _playerAnimatior.SetBool(currentAnimation, true);
    }
}
