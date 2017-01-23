using UnityEngine;
using System.Collections;

public class UI_Target : MonoBehaviour {

    [SerializeField]
    GameObject Camera;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(Camera.transform);
	}
}
