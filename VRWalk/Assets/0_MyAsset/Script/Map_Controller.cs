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
            NextMaptip = Instantiate(Maptip[Random.Range(0, 1)]);//これで0になるはず

            Destroy(Road[3]);
            Road[3] = Road[2];
            Road[2] = Road[1];
            Road[1] = Road[0];
            Road[0] = NextMaptip;
                        
        }
	}
}
