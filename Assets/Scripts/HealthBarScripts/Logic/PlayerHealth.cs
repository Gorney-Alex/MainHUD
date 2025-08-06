using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    
    private float _currentHealth;
    
    public float CurrentHealth
    {
        get { return _currentHealth; }
    }

    public void SetStartHealth()
    {
        _currentHealth = _maxHealth;
    }

    public void AddHealth(float amount)
    {
        _currentHealth += amount;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }

    public void RemoveHealth(float amount)
    {
        if (_currentHealth <= 0f)
        {
            _currentHealth = 0f;
            return;
        }
        
        _currentHealth -= amount;
    }
}
