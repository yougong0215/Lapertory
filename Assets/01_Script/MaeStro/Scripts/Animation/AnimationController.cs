using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AnimationController : MonoBehaviour
{
    Animator _playerAnimatior;
    private string currentAnimation;
    private void Awake()
    {
        _playerAnimatior = GetComponent<Animator>();
    }

    public void SettingAnimation(string animation)
    {
        _playerAnimatior?.SetBool(currentAnimation, false);
        currentAnimation = animation;
        _playerAnimatior.SetBool(currentAnimation, true);
    }
    
}
