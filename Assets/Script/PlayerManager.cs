using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        /*isGameOver = false;*/
    }

    // Update is called once per frame
    void Update()
    {
/*        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            
            gameOverScreen.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    public void ReplayLevel()
    {
        UIController.NumberOfDiamonds = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        UIController.isNextLevel = true;
        UIController.NumberOfDiamonds = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
