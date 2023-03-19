using UnityEngine;

[CreateAssetMenu(fileName = "EnemySetting", menuName = "SO")]
public class Enemy_Setting : ScriptableObject
{
    float Damage { get; set; }
    float Stoppingdistance { get; set; }

    enum job
    {
        melee,
        LongDistanceAttack,
    }
}
