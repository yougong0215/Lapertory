using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillCardUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI keyText;


    private void Awake()
    {
        nameText = transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        keyText = transform.Find("KeyText").GetComponent<TextMeshProUGUI>();
    }

    public void ValueSetting(GameObject _skilLData)
    {
        SkillBase skillBase = _skilLData.GetComponent<SkillBase>();

        nameText.text = skillBase.skillName;
        keyText.text = skillBase.skillKey.ToString();
    }
}
