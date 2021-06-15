using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon {

	void Start () {
	}
	
	public void Shoot(GameObject obj)
    {
		Vector3 initialPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		GameObject bullet1 = Instantiate(obj);
		GameObject bullet2 = Instantiate(obj);
		GameObject bullet3 = Instantiate(obj);
		GameObject bullet4 = Instantiate(obj);
		bullet1.transform.position = initialPosition;
		bullet2.transform.position = initialPosition;
		bullet3.transform.position = initialPosition;
		bullet4.transform.position = initialPosition;
		bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(3, 6, 0), ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(new Vector3(1, 8, 0), ForceMode.Impulse);
		bullet3.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 8, 0), ForceMode.Impulse);
		bullet4.GetComponent<Rigidbody>().AddForce(new Vector3(-3, 6, 0), ForceMode.Impulse);
	} 
}
