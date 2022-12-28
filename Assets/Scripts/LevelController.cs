using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;
using TMPro;

public class LevelController : MonoBehaviour
{
    public UnityEngine.UI.Image StartGame;
    public GameObject EclipseObject;
    public UnityEngine.UI.Image PlayButton;
    public GameObject PlayText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameWin()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale= 1.0f;
    }

    public void GameStart()
    {
        StartGame.DOFade(0f, 1f);
        EclipseObject.GetComponent<TMP_Text>().DOFade(0f, 1f);
        
    }
}
