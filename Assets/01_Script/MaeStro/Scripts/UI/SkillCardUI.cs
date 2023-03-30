using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillCardUI : MonoBehaviour
{
    private List<GameObject> engraveObjectList = new List<GameObject>();
    public TextMeshProUGUI engraveText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI keyText;
    public TextMeshProUGUI levelText;
    SkillKeySelecter _skillKeySelecter;

    SkillBase skillBase;
    bool isCangeKey;
    KeyCode changeKey;

    Color selectColor = new Color(1, 0.9f, 0);
    Color normalColor = new Color(0, 0, 0);
    private void Awake()
    {
        engraveText = transform.Find("EngraveText").GetComponent<TextMeshProUGUI>();
        nameText = transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        keyText = transform.Find("KeyText").GetComponent<TextMeshProUGUI>();
        levelText = transform.Find("LevelText").GetComponent<TextMeshProUGUI>();
        _skillKeySelecter = GameObject.Find("SkillKeySelecter").GetComponent<SkillKeySelecter>();
    }

    public void EngraveSetting(GameObject _skillData)
    {
        string engraveAreaText = "";
        SkillBase _skillBase_engrave = _skillData.GetComponent<SkillBase>();

        //_skillBase_engrave

        engraveText.text = engraveAreaText;
        
    }

    public void ValueSetting(GameObject _skilLData)
    {
        skillBase = _skilLData.GetComponent<SkillBase>();

        nameText.text = skillBase.skillName;
        keyText.text = skillBase.skillKey.ToString();
        levelText.text = skillBase.level.ToString();
    }

    private void OnGUI()
    {
        if(isCangeKey)
        {
            Event keyChangeEvent = Event.current;
            if (Input.anyKeyDown)
            {
                changeKey = keyChangeEvent.keyCode;
                skillBase.skillKey = changeKey;
                foreach(var _selectKey in _skillKeySelecter.skillKeyDic)
                {
                    if (_selectKey.Value == skillBase.gameObject)
                    {
                        Debug.Log(_selectKey);
                        _skillKeySelecter.skillKeyDic.Remove(_selectKey.Key);
                        _skillKeySelecter.skillKeyDic.Add(skillBase.skillKey, _selectKey.Value);
                        
                        break;
                    }
                }
                keyText.text = skillBase.skillKey.ToString();
                keyText.color = normalColor;
                isCangeKey = false;
            }
        }
        
    }

    public void ChangeKey()
    {
        
        isCangeKey = !isCangeKey;
        keyText.color = selectColor;
        keyText.text = $"> {skillBase.skillKey} <";
    }
}
