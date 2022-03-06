using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeDetailController : MonoBehaviour
{
    
    [SerializeField]
    private TextMeshProUGUI _coffeeName;
    
    [SerializeField]
    private Image _coffeeImage;
    
    [SerializeField]
    private Slider _coffeeSlider;
    
    [SerializeField]
    private Slider _milkSlider;
    
    [SerializeField]
    private Slider _sugarSlider;

    [SerializeField]
    private Button _defaultCoffee;
    
    [SerializeField]
    private TextMeshProUGUI _price;

    private int _sugar;

    private void Start()
    {
        _defaultCoffee.Select();
        _defaultCoffee.onClick?.Invoke();
    }

    private void SendCoffeeOrder()
    {
        throw new NotImplementedException();
    }


    public void SetDetails(CoffeeData coffeeData)
    {
        _coffeeName.text = coffeeData.coffeeName;
        _coffeeImage.sprite = coffeeData.coffeeImage;
        _price.text = $"{coffeeData.price} TL";

        if (coffeeData.isCustomCoffee)
        {
            _milkSlider.interactable = true;
            _coffeeSlider.interactable = true;
        }
        else
        {
            _milkSlider.interactable = false;
            _coffeeSlider.interactable = false;
        }

        _milkSlider.value = coffeeData.milkSlider * _milkSlider.maxValue;
        _coffeeSlider.value = coffeeData.coffeeSlider * _coffeeSlider.maxValue;
    }

    public void RoundSlider(Slider slider)
    {
        var val = Mathf.RoundToInt(slider.value);
        slider.value = val;

        if (slider.Equals(_sugarSlider))
        {
            _sugar = val;
        }
    }

    public void CalculatePrice()
    {
        if (!_milkSlider.interactable || !_coffeeSlider.interactable) return;
        _price.text = $"{5 + (_milkSlider.value + 1) * (_coffeeSlider.value + 1) * 0.4f:0}";
    }
}
