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

    private void Start()
    {
        Set_State(BossState.STATE_Start);
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
                break;
            case BossState.STATE_PatternA:
                break;
            case BossState.STATE_PatternB:
                break;
            case BossState.STATE_PatternC:
                break;
        }
        Cur_state.DoAction();
    }
}
