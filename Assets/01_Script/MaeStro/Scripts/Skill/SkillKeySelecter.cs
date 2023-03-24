using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillKeySelecter : MonoBehaviour
{
    public Dictionary<KeyCode, GameObject> skillKeyDic = new Dictionary<KeyCode, GameObject>();

    public void SettingKey(KeyCode key, GameObject skillObject)
    {
        foreach (var inKey in skillKeyDic)
        {
            if(inKey.Key == key)
            {
                return;
            }
        }
        skillKeyDic.Add(key, skillObject);
    }

    public void ChangeKey(KeyCode key, GameObject skillObject)
    {
        foreach (var selectData in skillKeyDic)
        {
            if(skillObject == selectData .Value)
            {
                skillKeyDic.Remove(selectData.Key);
            }
        }
        skillKeyDic.Add(key, skillObject);
    }

    private void Update()
    {
        
    }
}
