using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
   public void GoToScene1()
   {
        SceneManager.LoadScene(1);
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void GoToScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToScene4()
    {
        SceneManager.LoadScene(4);
    }

    //返回菜单
    public void AgainGame()
    {
        SceneManager.LoadScene(1);
    }

    #region 重玩本关
    public void RePlayrThisGame_2()
    {
        SceneManager.LoadScene(2);
    }

    public void RePlayrThisGame_3()
    {
        SceneManager.LoadScene(3);
    }

    public void RePlayrThisGame_4()
    {
        SceneManager.LoadScene(4);
    }

    #endregion
    public void Quit()
    {
        Application.Quit();
    }
}
