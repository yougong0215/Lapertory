using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillCardUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI keyText;

    SkillBase skillBase;
    bool isCangeKey;
    KeyCode changeKey;

    Color selectColor = new Color(1, 0.9f, 0);
    Color normalColor = new Color(0, 0, 0);
    private void Awake()
    {
        nameText = transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        keyText = transform.Find("KeyText").GetComponent<TextMeshProUGUI>();
    }

    public void ValueSetting(GameObject _skilLData)
    {
        skillBase = _skilLData.GetComponent<SkillBase>();

        nameText.text = skillBase.skillName;
        keyText.text = skillBase.skillKey.ToString();
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
                keyText.text = changeKey.ToString();
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
