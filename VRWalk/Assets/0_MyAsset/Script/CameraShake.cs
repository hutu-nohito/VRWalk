using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    [SerializeField]
    float rap_time = 0.5f;//頭を上下に揺らす間隔
    float time = 0;
    bool flag_up = true;//上か下か

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if (time > rap_time)
        {
            flag_up = !flag_up;
            time = 0;
        }

        if (flag_up)
        {
            transform.position += new Vector3(0,Time.deltaTime / 10,0);
        }
        else
        {
            transform.position -= new Vector3(0, Time.deltaTime / 10, 0);
        }
	}
}
