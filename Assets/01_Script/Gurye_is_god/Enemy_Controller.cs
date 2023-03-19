using UnityEngine;
using UnityEngine.AI;


public class Enemy_Controller : MonoBehaviour
{
    enum State
    {
        attack,
        follow,
        Die
    }
    State _state;
    [SerializeField] private Enemy_Setting _set;
    [SerializeField] private Transform _target;
    private NavMeshAgent _agent;



    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        #region setting
        
        #endregion
    }


    void Update()
    {
        _agent.SetDestination(_target.position);
    }
}
