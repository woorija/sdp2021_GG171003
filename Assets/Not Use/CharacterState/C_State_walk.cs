using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class C_State_walk : State
{
    public override void DoAction(MyState state)
    {
        StartCoroutine(Action());
        Debug.Log("WALK");
    }

    IEnumerator Action()
    {
        while (true) {
            bool GetKEY_A = Input.GetKey(KeyCode.A);
            bool GetKEY_S = Input.GetKey(KeyCode.S);
            bool GetKEY_D = Input.GetKey(KeyCode.D);
            bool GetKEY_W = Input.GetKey(KeyCode.W);
            bool GetKEY = GetKEY_A || GetKEY_S || GetKEY_D || GetKEY_W;

            if (!GetKEY)
            {
                gameObject.GetComponent<Character>().Set_State(MyState.STATE_IDEL);
                yield break;
            }

            if (GetKEY_A)
            {
                transform.position += Vector3.left * 0.2f;
            }
            if (GetKEY_S)
            {
                transform.position += Vector3.back * 0.2f;
            }
            if (GetKEY_D)
            {
                transform.position += Vector3.right * 0.2f;
            }
            if (GetKEY_W)
            {
                transform.position += Vector3.forward * 0.2f;
            }
            yield return new WaitForSeconds(0.03f);
        }

    }

    
}
*/