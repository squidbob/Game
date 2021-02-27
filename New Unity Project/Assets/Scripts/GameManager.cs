using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool end = false;
    public Text victorytext;

    public void EndGame()
    {
        if (end == false)
        {
            end = true;
            victorytext.text = "F";
            Invoke("restart", 2f);
        }

        
    }

    public void win()
    {
        victorytext.text = "You Win!";
        Invoke("restart", 0.7f);
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
