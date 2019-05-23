using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject CaveBG;
    public GameObject ForestBG;


    public void LoadScenes()
    {

        CaveBG.SetActive(false);
        ForestBG.SetActive(true);
        

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
