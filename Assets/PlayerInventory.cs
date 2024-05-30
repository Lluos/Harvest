using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int redSeeds = 5;
    public int fertilizer = 10;
    public int redFruit;
    public int money;
    public TextMeshProUGUI RedSeedText;
    public TextMeshProUGUI FertilizerText;
    public TextMeshProUGUI RedFruitText;
    public TextMeshProUGUI MoneyText;

    private void Start()
    {
        redFruit = 0;
        RedSeedText.text = redSeeds.ToString();
        FertilizerText.text = fertilizer.ToString();
    }

    public bool UseRedSeed()
    {
        if (redSeeds > 0)
        {
            redSeeds--;
            RedSeedText.text = redSeeds.ToString();
            return true;
        }
        return false;
    }

    public int UseFertilizer()
    {
        if (fertilizer > 0)
        {
            int usedFertilizer = Random.Range(1, 4);
            usedFertilizer = Mathf.Min(usedFertilizer, fertilizer);
            fertilizer -= usedFertilizer;
            FertilizerText.text = fertilizer.ToString();
            return usedFertilizer;
        }
        return 0;
    }

    public void AddHarvest(int rFruit)
    {
        redFruit += rFruit;
        RedFruitText.text = redFruit.ToString();
    }

    public void AddMoney( int amount)
    {
        money += amount;
        MoneyText.text = money.ToString();
    }
}
