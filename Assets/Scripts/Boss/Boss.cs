using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossState
{
    STATE_Start,
    STATE_Die,
    STATE_PatternA,
    STATE_PatternB,
    STATE_PatternC
}
public class Boss : MonoBehaviour
{
    BossState state;//현 스테이트

    State Cur_state;//가져올 스테이트 클래스

    MonsterHP HP;

    private void Start()
    {
        Set_State(BossState.STATE_Start);
        HP = GetComponent<MonsterHP>();
        HP.HPInit();
    }

    public void Set_State(BossState _state)
    {
        state = _state; //현재 스테이트 표기

        State temp = GetComponent<State>();
        if (temp != null)
        {
            Destroy(temp);
        }
        //이전 스테이트 제거

        switch (state)
        {
            case BossState.STATE_Start:
                Cur_state = gameObject.AddComponent<B_STATE_Start>();
                break;
            case BossState.STATE_Die:
                Cur_state = gameObject.AddComponent<B_STATE_Die>();
                break;
            case BossState.STATE_PatternA:
                Cur_state = gameObject.AddComponent<B_STATE_PatternA>();
                break;
            case BossState.STATE_PatternB:
                Cur_state = gameObject.AddComponent<B_STATE_PatternB>();
                break;
            case BossState.STATE_PatternC:
                Cur_state = gameObject.AddComponent<B_STATE_PatternC>();
                break;
        }
        Cur_state.DoAction();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            if (HP.hp > 0)
            {
                switch (other.GetComponent<BulletType>().Get_Type())
                {
                    case (int)PoolType.Bullet:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Bullet, other.gameObject);
                        break;
                    case (int)PoolType.Missile:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Missile, other.gameObject);
                        break;
                    case (int)PoolType.Arrow:
                        ObjectPoolManager.Instance.DeleteObj((int)PoolType.Arrow, other.gameObject);
                        break;
                }
                if (HP.Hit(1))
                {
                    Set_State(BossState.STATE_Die);
                }
            }
        }
    }
}
