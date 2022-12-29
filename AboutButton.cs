using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AboutButton : MonoBehaviour
{
    // Reference to the Button component
    private Button button;

    public string AboutScene;

    void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add a listener to the On Click event
        button.onClick.AddListener(() => GoToScene(AboutScene));
    }

    public void GoToScene(string AboutScene)
    {
        // Load the specified scene
        SceneManager.LoadScene(AboutScene);
    }
}