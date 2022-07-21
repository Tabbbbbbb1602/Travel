using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    // SINGLETON
    private static UIController _instance;
    public static UIController Instance => _instance;

    public GameObject scoreBoard;

    public GameObject nextLevel;

    public GameObject finishObject;

    public GameObject player;


    public static bool isNextLevel;

    public Text score;
    public Text result;
    public Text finishGame;

    public static int NumberOfDiamonds;
    private void Awake()
    {
        _instance = this;
        isNextLevel = false;
    }


    
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        finishObject.SetActive(false);
        if (!isNextLevel)
        {
            nextLevel.SetActive(false);
        }
        else
        {
            nextLevel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = NumberOfDiamonds.ToString();
        if(NumberOfDiamonds == 3)
        {
            if(SceneManager.GetActiveScene().buildIndex == 0)
            {
                result.text = $"Score: {NumberOfDiamonds.ToString()}";
                nextLevel.SetActive(true);
                player.SetActive(false);
            }else if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                finishObject.SetActive(true);
                player.SetActive(false);
                result.text = $"Score: {NumberOfDiamonds.ToString()}";
                finishGame.text = $"Finish Game !";
            }
            

        }


    }

    public static void DiaMondCollected()
    {
        NumberOfDiamonds++;
        
    }
}
