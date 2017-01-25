using UnityEngine;
using System.Collections;

/******************************************************************************/
/** @brief マップチップの管理
* @date 2017/01/22
* @author 石川
* @param[in] m_fringe 干渉縞の計算結果を格納
*
*/
/******************************************************************************/
/* 更新履歴
*   キュー作成
*/
/******************************************************************************/


public class Map_Controller : MonoBehaviour {

    [SerializeField]
    GameObject[] Maptip;//
    [SerializeField]
    GameObject[] Road;//道のオブジェクト。4つで固定
    GameObject NextMaptip;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	

        //端っこの処理
        if(Road[3].transform.position.z < -30)
        {
            int random_map = Random.Range(0, Maptip.Length + 1);
            if(random_map == 4)//キノコの楽園だったら一回再選出して確率を下げる
            {
                random_map = Random.Range(0, Maptip.Length + 1);
            }
            NextMaptip = Instantiate(Maptip[random_map]);

            Destroy(Road[3]);
            Road[3] = Road[2];
            Road[2] = Road[1];
            Road[1] = Road[0];
            Road[0] = NextMaptip;
                        
        }
	}
}
