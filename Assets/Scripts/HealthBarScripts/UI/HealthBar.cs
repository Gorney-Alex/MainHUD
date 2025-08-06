using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private float _healthValue;
    [SerializeField] private float _sliderspeed;
    
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _playerHealth.SetStartHealth();
    }

    private void Update()
    {
        CalculateHealthBar();
    }

    public void AddHealth() => _playerHealth.AddHealth(_healthValue);

    public void RemoveHealth() => _playerHealth.RemoveHealth(_healthValue);

    private void CalculateHealthBar()
    {
        float playerHealthPercentage = _playerHealth.CurrentHealth / 100;
        
        _slider.value = Mathf.MoveTowards(_slider.value,playerHealthPercentage,_sliderspeed);
    }
    
    
}
