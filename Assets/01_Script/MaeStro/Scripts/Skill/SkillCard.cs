using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkillCard : SkillCardBase
{
    RectTransform thisTrans;
    public override void CompleteSetting()
    {
        thisTrans = GetComponent<RectTransform>();
        thisTrans.localPosition = toMovePos;
    }
}
