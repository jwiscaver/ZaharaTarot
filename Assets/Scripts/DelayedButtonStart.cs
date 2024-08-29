using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class DelayedButtonDisplay : MonoBehaviour
{
    public GameObject button;       // Assign the button GameObject in the Inspector
    public float delay = 3f;        // Delay time in seconds

    private Button uiButton;        // Reference to the Button component

    void Start()
    {
        // Register the click event once the button is active
        uiButton = button.GetComponent<Button>();
        if (uiButton != null)
        {
            uiButton.onClick.AddListener(OnButtonClick);
        }

        // Start the coroutine that will activate the button after a delay
        StartCoroutine(ShowButtonAfterDelay());
    }

    IEnumerator ShowButtonAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Activate the button
        button.SetActive(true);

    }

    // Method to load the next scene (Menu)
    void OnButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
