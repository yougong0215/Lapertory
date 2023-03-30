using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngraveSetter : MonoBehaviour
{
    [SerializeField] private List<EngraveData> _engraveData = new List<EngraveData>();
    [SerializeField] private List<GameObject> _dataObjectList = new List<GameObject>();
    public GameObject engraveGameobject;
    public GameObject EngraveSetting()
    {
        int rand = Random.Range(0, _dataObjectList.Count);
        return _dataObjectList[rand];
    }
}
