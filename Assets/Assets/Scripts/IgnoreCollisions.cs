using UnityEngine;
using System.Collections;

public class IgnoreCollisions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.IgnoreLayerCollision(8,8,true);
	}
}
