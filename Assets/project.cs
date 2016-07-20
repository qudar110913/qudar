using UnityEngine;
using System.Collections;

public class project : MonoBehaviour 
{

	public GameObject prefab001;
	// Use this for initialization
	void Start () {                }
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) {
			//Debug.Log ("test");
			Instantiate(prefab001);
		}
	}
}