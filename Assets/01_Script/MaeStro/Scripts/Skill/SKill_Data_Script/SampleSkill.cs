using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSkill : SkillBase
{
    public override void FirstSetSkill()
    {
        skillKey = thisSkillData.skillKey;
        skillName = thisSkillData.skillName;
        skillCoolTime = thisSkillData.skillCoolTime;
        skillInfo = thisSkillData.skillInfo;
        effectDieTime = thisSkillData.effectDieTime;
        producePos = thisSkillData.producePos;
        skillEffect = thisSkillData.effecctPrefab;
    }

    public override void SettingSkillValue(int setLevelValue)
    {

    }
}
