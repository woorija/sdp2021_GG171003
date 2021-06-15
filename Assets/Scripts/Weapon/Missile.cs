using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour, IWeapon {

	void Start () {
	}
	
	public void Shoot(GameObject obj) {
		Vector3 initialPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		GameObject bullet1 = Instantiate(obj);
		GameObject bullet2 = Instantiate(obj);
		GameObject bullet3 = Instantiate(obj);
		GameObject bullet4 = Instantiate(obj);
		GameObject bullet5 = Instantiate(obj);
		bullet1.transform.position = initialPosition + new Vector3(0.7f, 0, 0);
		bullet2.transform.position = initialPosition + new Vector3(0.35f, 0, 0);
		bullet3.transform.position = initialPosition;
		bullet4.transform.position = initialPosition + new Vector3(-0.35f, 0, 0);
		bullet5.transform.position = initialPosition + new Vector3(-0.7f, 0, 0);
		bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet3.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet4.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
		bullet5.GetComponent<Rigidbody>().AddForce(new Vector3(0, 20, 0), ForceMode.Impulse);
	} 

}
