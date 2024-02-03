using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameOverScreen : MonoBehaviour
{
[SerializeField] playerHealth habar;

private void update()
{
    Debug.Log(habar.ok1);
}
public void restartGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
public void gameOver()
{
    if(ok1==0)
    {
    gameOvermort.SetActive(true);
    }
}
}
