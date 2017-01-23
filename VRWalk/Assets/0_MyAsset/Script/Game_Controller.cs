using UnityEngine;
using System.Collections;

/******************************************************************************/
/** @brief スコアの管理
* @date 2017/01/22
* @author 石川
* @param[in] m_fringe 干渉縞の計算結果を格納
*
*/
/******************************************************************************/
/* 更新履歴
*   スコア作成
*/
/******************************************************************************/


static public class Parameter
{
    static public int score = 0;
    static public bool flag_title = true;

}

public class Game_Controller : MonoBehaviour {

    [SerializeField]
    GameObject Title_UI;
    [SerializeField]
    GameObject StartButton_UI;
    [SerializeField]
    GameObject StopButton_UI;
    [SerializeField]
    GameObject Score_UI;

    // Use this for initialization
    void Start () {

        Time.timeScale = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartButton()
    {
        Title_UI.SetActive(false);
        StartButton_UI.SetActive(false);
        StopButton_UI.SetActive(true);
        Score_UI.SetActive(true);
        Parameter.flag_title = false;
        Time.timeScale = 1;
    }

    public void StopButtton()
    {
        Application.Quit();
    }
}
