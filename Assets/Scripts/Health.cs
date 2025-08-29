using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : IDamageble
{
    private float _maxValue;
    private float _minValue;
    private float _currentValue;

    public void TakeDamage(int damage)
    {
        if (damage > 0)
            _currentValue -= damage;

        if (_currentValue < _minValue)
            _currentValue = _minValue;
    }

    public void AddMaxValue(int value)
    {
        if (value > 0)
            _maxValue += value;
    }
}
