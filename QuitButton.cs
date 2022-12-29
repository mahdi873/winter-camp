using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Reference to the Button component
    private Button button;

    void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add a listener to the On Click event
        button.onClick.AddListener(Quit);
    }

    public void Quit()
    {
        // Quit the application
        Application.Quit();
    }
}