using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon {

	void Start () {
	}
	
	public void Shoot() {
		Vector3 initialPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		for(int i = 0; i < 5; i++)
        {

        }
		GameObject bullet1 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Missile);
		GameObject bullet2 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Missile);
		GameObject bullet3 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Missile);
		GameObject bullet4 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Missile);
		GameObject bullet5 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Missile);
		bullet1.transform.position = initialPosition + new Vector3(0.7f, 0, 0);
		bullet2.transform.position = initialPosition + new Vector3(0.35f, 0, 0);
		bullet3.transform.position = initialPosition;
		bullet4.transform.position = initialPosition + new Vector3(-0.35f, 0, 0);
		bullet5.transform.position = initialPosition + new Vector3(-0.7f, 0, 0);
		bullet1.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet2.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet3.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet4.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet5.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet3.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet4.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet5.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
	} 

}
