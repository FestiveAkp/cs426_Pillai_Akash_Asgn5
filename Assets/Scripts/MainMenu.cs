using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int player = 0;
    
    public Button human;
    public Button cat;
    public Button play;


    void Start()
    {
        Button humanBtn = human.GetComponent<Button>();
        humanBtn.onClick.AddListener(SelectHuman);
        
        Button catBtn = cat.GetComponent<Button>();
        catBtn.onClick.AddListener(SelectCat);
        
        Button playBtn = play.GetComponent<Button>();
        playBtn.onClick.AddListener(PlayGame);
    }

    public void SelectHuman()
    {
        player = 1;
    }

    public void SelectCat()
    {
        player = 3;
    }
    public void PlayGame()
    {
        if (player != 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
