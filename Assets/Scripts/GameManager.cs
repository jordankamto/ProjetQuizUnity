using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject result;
    public Text resultText;
    public Button[] Answerbuttons;
    public string correctAnswer;
    public string wrongAnswer;

    // Start is called before the first frame update
    void Start()
    {
        result.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoodAnswer()
    {
        result.SetActive(true);
        resultText.text = correctAnswer;
        // Changement de couleur (Rouge)

        // Déactivation des boutons
        for (int i = 0; i < Answerbuttons.Length; i++)
        {
            Answerbuttons[i].interactable = false;
        }
    }

    public void WrongAnswer()
    {
        result.SetActive(true);
        resultText.text = wrongAnswer;
        // Changement de couleur (Vert)

        // Déactivation des boutons
        for (int i = 0; i < Answerbuttons.Length; i++)
        {
            Answerbuttons[i].interactable = false;
        }
    }

    public void NextQuestion(string level)
    {
        // chargement du niveau suivant
        SceneManager.LoadScene(level);
    }
}