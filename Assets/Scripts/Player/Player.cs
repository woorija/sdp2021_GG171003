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
    private void Start()
    {
        Set_command();
        _rigid = GetComponent<Rigidbody>();
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
        //�̵� ���� ������
        //1ȸ�� 1Ŀ�ǵ常 ���� �� �켱���� �ο�
        if (CustomInputManager.Instance.GetKey((int)eKeycodeType.Attack)) return Com_Attack;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange1)) return Com_WeaponChange1;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange2)) return Com_WeaponChange2;
        else if (CustomInputManager.Instance.GetKeyDown((int)eKeycodeType.WeaponChange3)) return Com_WeaponChange3;
        //
        return null;
    }
}
