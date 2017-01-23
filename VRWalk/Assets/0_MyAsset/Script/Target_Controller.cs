using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Target_Controller : MonoBehaviour {

    [SerializeField]
    Image Target_UI;
    [SerializeField]
    Image Onpu_UI;

    [SerializeField]
    float look_time = 3;//見る時間（共通）
    float looking_time = 0;//見つめている時間

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (looking_time > 2 * look_time)//good
        {
            Target_UI.color = new Color(1, 0, 0, 0);//消す
            Onpu_UI.color = new Color(1, 0, 0.8f, 1);//つける
        }
        else if (looking_time > look_time)//good
        {
            Target_UI.color = new Color(1, 0, 0, 0);//消す
            Onpu_UI.color = new Color(1, 0, 0, 1);//つける
        }
        

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Vision")
        {
            Target_UI.color = new Color(1,0,0,1);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Vision")
        {
            looking_time += Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Vision")
        {
            Target_UI.color = new Color(0, 0, 1, 1);
            Onpu_UI.color = new Color(0, 0, 0, 0);//消す
            looking_time = 0;
        }
    }
}
