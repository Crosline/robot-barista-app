using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeData", menuName = "ScriptableObjects/CoffeeData")]
public class CoffeeData : ScriptableObject
{
    public int id = 0;
    
    public string coffeeName = "coffee";
    
    public float price = 10;

    public Sprite coffeeImage;
    
    [Range(0.0f, 1.0f)]
    public float coffeeSlider = 1f;
    
    [Range(0.0f, 1.0f)]
    public float milkSlider = 1f;

    public bool isCustomCoffee = false;
}
