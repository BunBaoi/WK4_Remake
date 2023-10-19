using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{

    public GameObject currentPlant;

    public Sprite currentPlantSprite;

    public Transform tiles;

    public LayerMask tileMask;

    public int suns;

    public TextMeshProUGUI sunTask;

    public LayerMask sunMask;

    public void BuyPlant(GameObject plant, Sprite sprite)
    {
        currentPlant = plant;
        currentPlantSprite = sprite;
    }

    private void Update()
    {
        sunTask.text = suns.ToString();


        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, tileMask);

        foreach (Transform tile in tiles)
            tile.GetComponent<SpriteRenderer>().enabled = false;

        if(hit.collider & currentPlant)
        {
            hit.collider.GetComponent<SpriteRenderer>().sprite = currentPlantSprite;
            hit.collider.GetComponent<SpriteRenderer>().enabled = true;

            if(Input.GetMouseButtonDown(0) && !hit.collider.GetComponent<Tile>().hasPlant) // Prevent the double planting
            {
                Instantiate(currentPlant, hit.collider.transform.position, Quaternion.identity);
                hit.collider.GetComponent<Tile>().hasPlant = true; // Prevent the double Planting as the tile is set to True
                currentPlant = null;
                currentPlantSprite = null;
            }
        }

        RaycastHit2D sunhit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, sunMask);

        if (sunhit.collider)
        {
            if (Input.GetMouseButtonDown(0))
            {
                suns += 25;
                Debug.Log("Collected 25");
                Destroy(sunhit.collider.gameObject);
            }

        }
    }
}
