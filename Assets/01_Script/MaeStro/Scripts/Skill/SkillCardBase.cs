using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCardBase : MonoBehaviour
{
    [Header("기본 정보")]
    public SkillData skillData;
    public SkillData thisSkillData { set { skillData = value; } }

    public string skillName;
    public float skillCool;
    public string skillInfo;

    public Vector2 toMovePos;

    public virtual void CompleteSetting()
    {

    }
}
