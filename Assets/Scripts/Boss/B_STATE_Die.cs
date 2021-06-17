using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_STATE_Die : State
{
    public override void DoAction()
    {
        StartCoroutine(Action());
    }

    IEnumerator Action()
    {
        while(transform.position.y <= 8)
        {
            Debug.Log(transform.position.y);
            transform.Translate(new Vector3(0, 0.04f, 0));
            yield return null;
        }
        transform.position = new Vector3(0, 8, 0);
        GameManager.Instance.GameClear();
    }
}
