using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScript : MonoBehaviour
{
    public GameObject canvasStart;
    public GameObject canvasEnd;
    public GameObject player;
    // Start is called before the first frame update
    public void Switch()
    {
        canvasStart.SetActive(false);
        player.GetComponent<PlayerController>().enabled = true;
    }

    public void GameOver()
    {
        Application.Quit();
    }

    public void Continue()
    {
        canvasEnd.SetActive(false);
    }
}
