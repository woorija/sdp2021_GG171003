using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eKeycodeType
{
    Attack,
    WeaponChange1,
    WeaponChange2,
    WeaponChange3,
    UpMove,
    LeftMove,
    DownMove,
    RightMove
}

public class Player : MonoBehaviour
{
    Command Com_Attack, Com_WeaponChange1, Com_WeaponChange2, Com_WeaponChange3;
    Rigidbody _rigid;

    MonsterHP HP;
    private void Start()
    {
        Set_command();
        _rigid = GetComponent<Rigidbody>();
        HP = GetComponent<MonsterHP>();
        HP.HPInit();
    }

    private void Update()
    {
        Move_commnad();
        if (!CustomInputManager.Instance.isKeychange)
        {
            Command command = Get_command();
            if (command != null)
            {
                command.execute();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BossBullet"))
        {
            if (HP.hp > 0)
            {
                ObjectPoolManager.Instance.DeleteObj((int)PoolType.BossBullet, other.gameObject);
                if (HP.Hit(1))
                {
                    GameManager.Instance.GameOver();
                }
            }
        }
    }

    void Move_commnad()
    {
        Vector3 speed = Vector3.zero;
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.UpMove))
            speed += Vector3.up * Time.deltaTime;
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.DownMove))
            speed += Vector3.down * Time.deltaTime;
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.LeftMove))
            speed += Vector3.left * Time.deltaTime;
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.RightMove))
            speed += Vector3.right * Time.deltaTime;
        _rigid.velocity = speed * 2000;
    }

    void Set_command()
    {
        Com_Attack = gameObject.AddComponent<Attack>();
        Com_WeaponChange1 = gameObject.AddComponent<WeaponChange1>();
        Com_WeaponChange2 = gameObject.AddComponent<WeaponChange2>();
        Com_WeaponChange3 = gameObject.AddComponent<WeaponChange3>();

        Com_Attack.Setting();
        Com_WeaponChange1.Setting();
        Com_WeaponChange2.Setting();
        Com_WeaponChange3.Setting();
    }

    Command Get_command()
    {
        //이동 제외 나머지
        //1회에 1커맨드만 가능 및 우선순위 부여
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.Attack)) return Com_Attack;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange1)) return Com_WeaponChange1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange2)) return Com_WeaponChange2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange3)) return Com_WeaponChange3;
        //
        return null;
    }
}
