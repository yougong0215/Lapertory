using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillKeySelecter : MonoBehaviour
{
    public Dictionary<KeyCode, SkillData> skillKeyDic = new Dictionary<KeyCode, SkillData>();

    public void SettingKey(KeyCode key, SkillData skillData)
    {
        foreach (var inKey in skillKeyDic)
        {
            if(inKey.Key == key)
            {
                return;
            }
        }
        skillKeyDic.Add(key, skillData);
    }

    public void ChangeKey(KeyCode key, SkillData skillData)
    {
        foreach (var selectData in skillKeyDic)
        {
            if(skillData == selectData .Value)
            {
                skillKeyDic.Remove(selectData.Key);
            }
        }
        skillKeyDic.Add(key, skillData);
    }

    private void Update()
    {
        
    }
}
