using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillKeySelecter : MonoBehaviour
{
    public Dictionary<KeyCode, SkillData> skillKeyDic = new Dictionary<KeyCode, SkillData>();
    public SkillData selectSkillData;
    [SerializeField] private GameObject _KeyPanel;
    [SerializeField] private GameObject _keyPrefab;

    [SerializeField] private int keyCount;
    GameObject currentKey;
    TextMeshProUGUI _keyText;
    public void SettingKey()
    {
        
    }
}
