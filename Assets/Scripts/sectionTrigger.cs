using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sectionTrigger : MonoBehaviour
{
    public GameObject roadSection;

    public bool lose = false;
    public int points;
    public float timer;
    public int seconds;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI pointsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lose == false)
        {
            timer += Time.deltaTime;

            int minutes = Mathf.FloorToInt(timer / 60);
            seconds = Mathf.FloorToInt(timer % 60);
            string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
            timeText.text = timeString;
        } else
        {
            SceneManager.LoadScene("mainScene");
        }
        
    }

    private void OnDestroy()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (points > highScore)
        {
            PlayerPrefs.SetInt("HighScore", points);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("trigger")){
            Instantiate(roadSection, new Vector3(0, 0, -30), Quaternion.identity);
        }

        if (other.gameObject.CompareTag("coin"))
        {
            points++;
            pointsText.text = points.ToString();
        }

        if (other.gameObject.CompareTag("diamond"))
        {
            points += 10;
            pointsText.text = points.ToString();
        }

        if (other.gameObject.CompareTag("cone"))
        {
            points -= 3;
            pointsText.text = points.ToString();
        }

        if (other.gameObject.CompareTag("lose"))
        {
            lose = true; 
        }
    }
}
