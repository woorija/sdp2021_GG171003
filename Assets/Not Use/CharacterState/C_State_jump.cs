using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class C_State_jump : State
{
    public override void DoAction(MyState state)
    {
        StartCoroutine(Action());
        Debug.Log("JUMP");
    }

    IEnumerator Action()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.Impulse);
        yield return null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane"))
        {
            gameObject.GetComponent<Character>().Set_State(MyState.STATE_IDEL);
        }
    }
}

*/