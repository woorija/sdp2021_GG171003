using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterB : MonoBehaviour
{
    MonsterBFactory factory;
    IMonsterMovement Move;
    private void Start()
    {
        Move = GetComponent<mMoveAdaptB>();
        Move.MoveStart();
    }

    public void SetFactory(MonsterBFactory _fac)
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
