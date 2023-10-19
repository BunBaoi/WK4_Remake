using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantSlot : MonoBehaviour
{

    public Sprite plantSprite;

    public GameObject plantObject;

    public int price;

    public Image Icon;
    public TextMeshProUGUI priceText;


    private GameManager gms;

    private void Start()
    {
        gms = GameObject.Find("GameManager").GetComponent<GameManager>();
        GetComponent<Button>().onClick.AddListener(BuyPlant);
    }

    private void BuyPlant()
    {
        if(gms.suns >= price && !gms.currentPlant)
        {
            gms.suns -= price;
            gms.BuyPlant(plantObject, plantSprite);
        }


        gms.BuyPlant(plantObject, plantSprite);

    }

    private void OnValidate()
    {
        if(plantSprite)
        {
            Icon.enabled = true;
            Icon.sprite = plantSprite;
            priceText.text = price.ToString();
        }
        else
        {
            Icon.enabled = false;
        }
    }

}
