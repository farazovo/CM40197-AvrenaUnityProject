using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneManagerScript : MonoBehaviour
{
    private static SceneManagerScript instance;
    private int spacePressCount = 0;
    public TMP_InputField inputBox1;
    public TMP_InputField inputBox2;
    public TMP_InputField inputBox3;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                HandleSpacePress();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                LoadNextScene();
            }
        }
    }

    void HandleSpacePress()
    {
        spacePressCount++;

        switch (spacePressCount)
        {
            case 1:
                if (inputBox1 != null)
                {
                    inputBox1.text = "Purple";
                }
                break;
            case 2:
                if (inputBox2 != null)
                {
                    inputBox2.text = "Apple";
                }
                break;
            case 3:
                if (inputBox3 != null)
                {
                    inputBox3.text = "Car";
                }
                break;
            default:
                LoadNextScene();
                break;
        }
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
