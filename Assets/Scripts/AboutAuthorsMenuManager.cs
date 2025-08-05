using UnityEngine;

public class AboutAuthorsMenuManager : MonoBehaviour
{
    [SerializeField] MainMenuManager _mainMenuManager;
    
    public void PressBackButton() =>  _mainMenuManager.TurnOnStartMenu();
}
