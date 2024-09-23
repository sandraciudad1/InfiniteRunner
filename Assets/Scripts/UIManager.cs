using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject instructions;
    [SerializeField] TextMeshProUGUI score;
    int points, maxPoints;

    private void Awake()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        score.text = highScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void infoBtnPressed()
    {
        instructions.SetActive(true);
    }

    public void closeBtnPressed()
    {
        instructions.SetActive(false);
    }
}
