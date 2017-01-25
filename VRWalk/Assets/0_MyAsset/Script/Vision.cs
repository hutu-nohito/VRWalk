using UnityEngine;
using System.Collections;

/******************************************************************************/
/** @brief 視線の管理
* @date 2017/01/22
* @author 石川
* 得点や種類もここで管理
*
*/
/******************************************************************************/
/* 更新履歴
*   作成
*/
/******************************************************************************/

public class Vision : MonoBehaviour {

    [SerializeField]
    float look_time = 1;//見る時間（共通）
    float looking_time = 0;//見つめている時間

    bool flag_good = false;
    bool flag_perfect = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //得点処理（今は2枚抜きは考えない）
        if (!flag_good)
        {
            if (looking_time > look_time)//good
            {
                Parameter.score += 10;
                flag_good = true;
            }
        }
        if (!flag_perfect)
        {
            if (looking_time > look_time * 2)//Parfect
            {
                Parameter.score += 50;
                flag_perfect = true;
            }
        }
        
	}

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Target")//得点になるなら時間を加算
        {
            looking_time += Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Target")//外れたら戻す
        {
            looking_time = 0;
            flag_good = false;
            flag_perfect = false;
        }
    }
}
