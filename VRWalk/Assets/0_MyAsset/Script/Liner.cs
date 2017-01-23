using UnityEngine;
using System.Collections;

/******************************************************************************/
/** @brief 道を動かす
* @date 2017/01/22
* @author 石川
* @param[in] m_fringe 干渉縞の計算結果を格納
*
*/
/******************************************************************************/
/* 更新履歴
*  直線作成
*/
/******************************************************************************/


public class Liner : MonoBehaviour {

    [SerializeField]
    float speed;//
                        // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += new Vector3(0,0,speed * Time.deltaTime);

	}
}
