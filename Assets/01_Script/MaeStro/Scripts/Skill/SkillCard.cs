using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCard : MonoBehaviour
{
    [Header("기본 정보")]
    public SkillData skillData;
    public SkillData thisSkillData { set { skillData = value; } }

    public string skillName;
    public float skillCool;
    public string skillInfo;

    private void Awake()
    {
        skillName = skillData.skillName;
        skillCool = skillData.skillCoolTime;
        skillInfo = skillData.skillInfo;
    }

}
