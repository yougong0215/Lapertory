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
        currentAnimation = animation;
        _playerAnimatior.SetBool(currentAnimation, true);
    }
    public void DeAccesAnimation(string animation)
    {
        _playerAnimatior?.SetBool(currentAnimation, false);
    }
}
