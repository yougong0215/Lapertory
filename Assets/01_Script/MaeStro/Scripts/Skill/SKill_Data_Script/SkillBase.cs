using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBase : MonoBehaviour
{ 
    //여긴 정보를 받는 곳 이다 꼬마야.
    public SkillData thisSkillData;
    public KeyCode skillKey;
    public string skillName;
    public float skillCoolTime;
    public string skillInfo;

    public float effectDieTime;
    public Vector3 producePos;

    private void Awake()
    {
        
    }
    public virtual void UseSkill()
    {

    }
}
