using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _mainMenuVisualTree;
    private Button _playButton;
    private Button _quitButton;
    [SerializeField] int SceneID;

    

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _mainMenuVisualTree = _document.rootVisualElement.Q("MainMenuVisualTree");
        _playButton = _mainMenuVisualTree.Q("PlayButton") as Button;
        _quitButton = _mainMenuVisualTree.Q("QuitButton") as Button;
    }

    private void OnEnable()
    {
        _playButton.RegisterCallback<ClickEvent>(OnPlayButtonClick);
        _quitButton.RegisterCallback<ClickEvent>(OnQuitButtonClick);
    }
    private void OnDisable()
    {
        _playButton.UnregisterCallback<ClickEvent>(OnPlayButtonClick);
        _quitButton.UnregisterCallback<ClickEvent>(OnQuitButtonClick);
    }
    private void OnPlayButtonClick(ClickEvent evt)
    {
        _mainMenuVisualTree.style.display = DisplayStyle.None;
        SceneManager.LoadScene(SceneID);
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnQuitButtonClick(ClickEvent evt)
    {
        _mainMenuVisualTree.style.display = DisplayStyle.None;
        //Debug.Log("Quit Button Clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
