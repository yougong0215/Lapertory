using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillCardUI : MonoBehaviour
{
    [SerializeField] private Canvas _skillSettingCanvas;
    [SerializeField] private GameObject _content;
    [SerializeField] private GameObject _cardUIPrefab;
    private RectTransform _contentRect;
    bool canvasActive;
    PlayerSkill _playerSkill;

    TextMeshProUGUI nameText;
    TextMeshProUGUI keyText;
    private void Awake()
    {
        _playerSkill = GameObject.Find("Player").GetComponent<PlayerSkill>();
        _skillSettingCanvas = GameObject.Find("SkillSettingCanvas").GetComponent<Canvas>();
        _contentRect = _content.GetComponent<RectTransform>();
    }
    private void Start()
    {
        _skillSettingCanvas.enabled = canvasActive;
    }

    public void SettingPanel()
    {
        canvasActive = _skillSettingCanvas.enabled;
        _skillSettingCanvas.enabled = !canvasActive;

        if(canvasActive)
        {
            for(int i = 0; i < _playerSkill.playerCanUseSkillList.Count; i++)
            {
                GameObject _cardUI = Instantiate(_cardUIPrefab, _content.transform);

                nameText = _cardUI.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
                keyText = _cardUI.transform.Find("KeyText").GetComponent<TextMeshProUGUI>();
            }
        }
    }
    
}
