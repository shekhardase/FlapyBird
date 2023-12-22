using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerscore;
    public GameObject gameoverscreen;
    public Text scoretext;

   public void addscore()
   {
    playerscore = playerscore + 1;
    scoretext.text = playerscore.ToString(); 
   }
   public void Restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void GameOver()
   {
    gameoverscreen.SetActive(true);
   }

}
