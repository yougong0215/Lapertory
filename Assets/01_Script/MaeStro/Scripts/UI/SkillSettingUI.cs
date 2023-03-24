using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SkillSettingUI : MonoBehaviour
{
    [SerializeField] private Canvas _skillSettingCanvas;
    [SerializeField] private GameObject _content;
    [SerializeField] private GameObject _cardUIPrefab;
    private RectTransform _contentRect;
    bool canvasActive;
    PlayerSkill _playerSkill;
    SkillCardUI _selectCardUI;
    List<GameObject> _cardUIList = new List<GameObject>();
    float _deltaX;
    private void Awake()
    {
        _playerSkill = GameObject.Find("Player").GetComponent<PlayerSkill>();
        _skillSettingCanvas = GameObject.Find("SkillSettingCanvas").GetComponent<Canvas>();
        _contentRect = _content.GetComponent<RectTransform>();
    }
    private void Start()
    {
        _skillSettingCanvas.enabled = canvasActive;
        _contentRect.sizeDelta = new Vector3(100, 700);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SettingPanel();
        }
    }

    public void SettingPanel()
    {
        canvasActive = _skillSettingCanvas.enabled;
        _skillSettingCanvas.enabled = !canvasActive;
        if (_skillSettingCanvas.enabled)
        {
            for(int i = 0; i < _playerSkill.playerCanUseSkillList.Count; i++)
            {
                GameObject _cardUI = Instantiate(_cardUIPrefab, _content.transform);
                _cardUIList.Add(_cardUI);
                _selectCardUI = _cardUI.GetComponent<SkillCardUI>();

                _deltaX = _contentRect.sizeDelta.x + 500;

                _contentRect.sizeDelta = new Vector2(_deltaX, 0);
                _selectCardUI.ValueSetting(_playerSkill.playerCanUseSkillList[i]);
            }
        }
        else
        {
            foreach(GameObject selectUI in _cardUIList)
            {
                Destroy(selectUI);
            }
        }
    }
    
}
