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

    public void ValueSetting(SkillData _skilLData)
    {
        Debug.Log(_skilLData);
        nameText.text = _skilLData.skillName;
        keyText.text = _skilLData.skillKey.ToString();
    }
}
