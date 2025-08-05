using UnityEngine;

public class StartMenuManager : MonoBehaviour
{
    [SerializeField] private MainMenuManager _mainMenuManager;
    [SerializeField] private GameObject _description;

    public void PressToggleChanged(bool toggleState) => _description.SetActive(toggleState);

    public void PressPlayButton() =>  _mainMenuManager.TurnOnPlayMenu();

    public void PressAboutAuthorsButton() => _mainMenuManager.TurnOnAboutAuthorsMenu();
    
    public void PressExitButton() => Application.Quit();
}
