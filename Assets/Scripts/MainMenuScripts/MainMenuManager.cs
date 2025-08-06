using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _aboutAuthorsMenu;
    [SerializeField] private GameObject _playMenu;

    private void Awake()
    {
        _startMenu.SetActive(true);
        _aboutAuthorsMenu.SetActive(false);
        _playMenu.SetActive(false);
    }

    public void TurnOnStartMenu()
    {
        _startMenu.SetActive(true);
        _aboutAuthorsMenu.SetActive(false);
        _playMenu.SetActive(false);
    }
    
    public void TurnOnAboutAuthorsMenu()
    {
        _startMenu.SetActive(false);
        _aboutAuthorsMenu.SetActive(true);
        _playMenu.SetActive(false);
    }
    
    public void TurnOnPlayMenu()
    {
        _startMenu.SetActive(false);
        _aboutAuthorsMenu.SetActive(false);
        _playMenu.SetActive(true);
    }
}
