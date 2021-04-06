using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_State_attack : State
{
    public override void DoAction(MyState state)
    {
        StartCoroutine(Action());
        Debug.Log("ATTACK");
    }

    IEnumerator Action()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.GetComponent<Character>().Set_State(MyState.STATE_IDEL);
    }
}
