using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimationMenu;
using System;

public class PlayerAnimation : MonoBehaviour
{
    AnimContainer _animContainer;
    Animator _playerAnimator;
    public Animation playerAnimation;
    Dictionary<animationMenu, Animation> _aniDic = null;
    private void Awake()
    {
        _aniDic = new Dictionary<animationMenu, Animation>();
        _playerAnimator = GetComponent<Animator>();
    }

    private void Start()
    {
        foreach(animationMenu animation in Enum.GetValues(typeof(animationMenu)))
        {
            foreach(Animation selectAni in _animContainer.playerAnimation)
            {
                if(selectAni.name.Contains($"{animation}"))
                {
                    _aniDic.Add(animation, selectAni);
                }
            }
        }
    }

    public void AccesAnimation(animationMenu anima)
    {
        playerAnimation = _aniDic[anima];
        //애니매이터로 실행
    }
}
