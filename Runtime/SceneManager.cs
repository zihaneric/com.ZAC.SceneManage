using UnityEngine;

namespace Zac.SceneManager
{
    /// <summary>
    /// 場景管理器:切換場景與退出遊戲
    /// </summary>
    public class SceneManager : MonoBehaviour
    {   
        //按鈕與程式溝通的方法
        // 1. 定義公開方法
        // 2. 此腳本掛在遊戲物件上
        // 3. 按鈕上設定 OnClick 事件
        
        
        
        
        [SerializeField, Range(0.3f, 1), Header("音效時間")]    //增加面板bar條
        private float soundDuration = 0.7f;

        private int nameSceneToChange;

        /// <summary>
        /// 用INT切換場景
        /// </summary>
        /// <param name="numScene">遊戲場景</param>
        public void ChangeScene(int numScene)
        {
            nameSceneToChange = numScene;
            Invoke("DelayChangeScene", soundDuration);
        }
        private void DelayChangeScene()
        {
            //print("切換場景");
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameSceneToChange);
            //UnityEngine.SceneManagement.SceneManager.LoadScene("遊戲場景");

        }

        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);  //延遲啟動
        }
        private void DelayQuit()
        {
            print("離開遊戲");
            Application.Quit();
        }
    }

}