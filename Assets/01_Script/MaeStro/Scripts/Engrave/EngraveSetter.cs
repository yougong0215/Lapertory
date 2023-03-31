using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngraveSetter : MonoBehaviour
{
    [SerializeField] private List<GameObject> _engraveDataObjectList = new List<GameObject>();
    public GameObject engraveGameobject;
    public GameObject EngraveSetting()
    {
        int rand = Random.Range(0, _engraveDataObjectList.Count);
        return _engraveDataObjectList[rand];
    }
}
