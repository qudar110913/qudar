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
		float ver = Input.GetAxis ("Vertical");
		float hor = Input.GetAxis ("Horizontal");
		Vector2 vec = new Vector2(ver,hor);
		if(vec.magnitude > 0)
		{
			transform.position=new Vector3(transform.position.x+ver,transform.position.y,transform.position.z+hor);
		}
	}
}

//{
//	{
//		if (Input.GetButtonDown ("Fire1")) {
//			//Debug.Log ("test");
//			Instantiate(prefab001);
//		}
//	}
//}
