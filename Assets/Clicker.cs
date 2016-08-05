using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clicker : MonoBehaviour {

	public int brownies = 0;
	public Text brownieCount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			brownies++;
			brownieCount.text = brownies.ToString ();
			transform.localScale = new Vector3 (3.75f, 2.25f, 1f);
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			transform.localScale = new Vector3 (4f, 2.5f, 1f);
		}
	}
}
