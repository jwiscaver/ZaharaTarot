using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject tarotExplanationPanel;
    public GameObject tipsPanel;
    public AudioSource backgroundAudio;

    // Method to show the Tarot Explanation panel
    public void ShowTarotExplanation()
    {
        tarotExplanationPanel.SetActive(true);
        tipsPanel.SetActive(false);  // Ensure the Tips panel is hidden
    }

    // Method to show the Tarot Reading Tips panel
    public void ShowTipsPanel()
    {
        tipsPanel.SetActive(true);
        tarotExplanationPanel.SetActive(false);
    }

    // Method to hide all panels
    public void HideAllPanels()
    {
        tarotExplanationPanel.SetActive(false);
        tipsPanel.SetActive(false);
    }

    public void GoToShuffle()
    {
        backgroundAudio.Play();
        SceneManager.LoadScene("Shuffle");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayClickAudio()
    {
        GetComponent<AudioSource>().Play();
    }
}