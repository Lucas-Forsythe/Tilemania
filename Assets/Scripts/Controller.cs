using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class Controller : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void TakeLife()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        lives--;
        SceneManager.LoadScene(currentSceneIndex);
    }
    
    void Update()
    {
        
    }
}
