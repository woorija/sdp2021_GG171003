using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_STATE_Start : State
{
    public override void DoAction()
    {
        StartCoroutine(Action());
    }

    IEnumerator Action()
    {
        transform.position = new Vector3(0, 8, 0);
        while(transform.position.y >= 4)
        {
            Debug.Log(transform.position.y);
            transform.Translate(new Vector3(0, -0.02f, 0));
            yield return null;
        }
        transform.position = new Vector3(0, 4, 0);
        gameObject.GetComponent<Boss>().Set_State(BossState.STATE_PatternA);
    }
}
