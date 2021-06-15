using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterA : MonoBehaviour
{
    MonsterAFactory factory;
    IMonsterMovement Move;
    private void Start()
    {
        Move = GetComponent<mMovement>();
        Move.MoveStart();
    }

    public void SetFactory(MonsterAFactory _fac)
    {
        factory = _fac;
    }

    void Die()
    {
        factory.DeleteMonster(gameObject);
    }

    void OnNotity()
    {
        Die();
    }
}
