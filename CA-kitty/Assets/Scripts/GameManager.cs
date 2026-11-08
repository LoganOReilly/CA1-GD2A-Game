using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int box = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (box == 2)
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }

    public void AddBox()
    {
        box ++;
    }
}
