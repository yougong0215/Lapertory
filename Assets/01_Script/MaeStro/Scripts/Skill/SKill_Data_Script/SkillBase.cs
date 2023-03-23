using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{ 
    //여긴 정보를 받는 곳 이다 꼬마야.
    [SerializeField] private SkillData _thisSkillData;
    public KeyCode skillKey;

    public virtual void UseSkill()
    {

    }
}
