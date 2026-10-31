using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private UIDocument _document;
    private VisualElement _mainMenuVisualTree;
    private Button _playButton;
    [SerializeField] int SceneID;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _mainMenuVisualTree = _document.rootVisualElement.Q("MainMenuVisualTree");
        _playButton = _mainMenuVisualTree.Q("PlayButton") as Button;
    }

    private void OnEnable()
    {
        _playButton.RegisterCallback<ClickEvent>(OnPlayButtonClick);
    }
    private void OnDisable()
    {
        _playButton.UnregisterCallback<ClickEvent>(OnPlayButtonClick);
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
}
