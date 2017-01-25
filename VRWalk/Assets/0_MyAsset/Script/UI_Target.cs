using UnityEngine;
using System.Collections;

public class UI_Target : MonoBehaviour {

    [SerializeField]
    GameObject MainCamera;

    // Use this for initialization
    void Start () {

        MainCamera = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(MainCamera.transform);
	}
}
