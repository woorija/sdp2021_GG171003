using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_State_idel : State
{
    public override void DoAction(MyState state)
    {
        StartCoroutine(Action());
        Debug.Log("IDEL");
    }

    IEnumerator Action()
    {
        yield break;
    }
}
