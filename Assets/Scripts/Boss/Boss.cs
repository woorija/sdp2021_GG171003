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
    BossState state;//�� ������Ʈ

    State Cur_state;//������ ������Ʈ Ŭ����

    private void Start()
    {
        Set_State(BossState.STATE_Start);
    }

    public void Set_State(BossState _state)
    {
        state = _state; //���� ������Ʈ ǥ��

        State temp = GetComponent<State>();
        if (temp != null)
        {
            Destroy(temp);
        }
        //���� ������Ʈ ����

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
