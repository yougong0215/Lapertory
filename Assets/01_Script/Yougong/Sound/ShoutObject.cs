using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoutObject : MonoBehaviour
{
    [SerializeField] SoundList _sl;
    public SoundList ReturnList()
    {
        return _sl;
    }

}
