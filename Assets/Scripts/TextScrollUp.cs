using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScrollUp : MonoBehaviour
{
    public float scrollSpeed = 50f;        // Speed at which the text scrolls
    public float timeToLoadScene = 20f;    // Time in seconds before loading the new scene
    private float timer = 0f;              // Timer to track elapsed time
    private RectTransform textRectTransform;

    void Start()
    {
        // Get the RectTransform component from the TextMeshPro UI element
        textRectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Move the text upwards
        textRectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);

        // Increment the timer by the time that has passed since the last frame
        timer += Time.deltaTime;

        // Check if 10 seconds have passed
        if (timer >= timeToLoadScene)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
