using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    [SerializeField] MainMenuManager _mainMenuManager;
    
    public void PressBackButton() =>  _mainMenuManager.TurnOnStartMenu();
}
