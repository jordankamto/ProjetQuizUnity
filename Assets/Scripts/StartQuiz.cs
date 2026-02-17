using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuiz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartQuizz()
    {
        SceneManager.LoadScene("Quiz 1");
    }
}
