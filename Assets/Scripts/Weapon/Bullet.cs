using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon {
	
	public void Shoot(GameObject obj)
    {
		Vector3 initialPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		GameObject bullet1 = Instantiate(obj);
        bullet1.transform.position = initialPosition;
		bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
	} 

}
