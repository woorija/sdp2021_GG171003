using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public enum MyState
{
    STATE_IDEL,
    STATE_WALK,
    STATE_JUMP,
    STATE_ATTACK
}
public class Character : MonoBehaviour
{
    MyState state;//�� ������Ʈ

    State Cur_state;//������ ������Ʈ Ŭ����

    public void Set_State(MyState _state)
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
            case MyState.STATE_IDEL:
                Cur_state = gameObject.AddComponent<C_State_idel>();
                Cur_state.DoAction(state);
                break;
            case MyState.STATE_WALK:
                Cur_state = gameObject.AddComponent<C_State_walk>();
                Cur_state.DoAction(state);
                break;
            case MyState.STATE_JUMP:
                Cur_state = gameObject.AddComponent<C_State_jump>();
                Cur_state.DoAction(state);
                break;
            case MyState.STATE_ATTACK:
                Cur_state = gameObject.AddComponent<C_State_attack>();
                Cur_state.DoAction(state);
                break;
        }
    }

    private void Start()
    {
        Set_State(MyState.STATE_IDEL);
    }
    void Update()
    {
        switch (state)
        {
            case MyState.STATE_IDEL:
                if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S))
                {
                    Set_State(MyState.STATE_WALK);
                }
                else if (Input.GetKeyDown(KeyCode.Space))
                {
                    Set_State(MyState.STATE_JUMP);
                }
                else if (Input.GetKeyDown(KeyCode.Z))
                {
                    Set_State(MyState.STATE_ATTACK);
                }
                break;
            case MyState.STATE_WALK:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Set_State(MyState.STATE_JUMP);
                }
                else if (Input.GetKeyDown(KeyCode.Z))
                {
                    Set_State(MyState.STATE_ATTACK);
                }
                break;
            case MyState.STATE_JUMP:
                break;
            case MyState.STATE_ATTACK:
                
                break;
        }
    }
}
*/