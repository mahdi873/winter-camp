using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    // Reference to the Button component
    private Button button;

    public string SampleScene;

    void Start()
    {
        // Get the Button component
        button = GetComponent<Button>();

        // Add a listener to the On Click event
        button.onClick.AddListener(() => GoToScene(SampleScene));
    }

    public void GoToScene(string SampleScenee)
    {
        // Load the specified scene
        SceneManager.LoadScene(SampleScene);
    }
}