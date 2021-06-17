using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon {

	void Start () {
	}
	
	public void Shoot()
    {
		Vector3 initialPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		GameObject bullet1 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Arrow);
		GameObject bullet2 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Arrow);
		GameObject bullet3 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Arrow);
		GameObject bullet4 = ObjectPoolManager.Instance.MakeObj((int)PoolType.Arrow);
		bullet1.transform.position = initialPosition;
		bullet2.transform.position = initialPosition;
		bullet3.transform.position = initialPosition;
		bullet4.transform.position = initialPosition;
		bullet1.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet2.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet3.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet4.GetComponent<Rigidbody>().velocity = Vector3.zero;
		bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(3, 6, 0), ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(new Vector3(1, 8, 0), ForceMode.Impulse);
		bullet3.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 8, 0), ForceMode.Impulse);
		bullet4.GetComponent<Rigidbody>().AddForce(new Vector3(-3, 6, 0), ForceMode.Impulse);
	} 
}
