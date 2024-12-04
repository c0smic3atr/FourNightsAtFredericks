using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableManager : MonoBehaviour
{
    public TextMeshProUGUI collectableDisplay;
    public int numberOfPizzas;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCount();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateCount()
    {
        numberOfPizzas = GameObject.FindGameObjectsWithTag("Pizza").Length;
        collectableDisplay.text = $"Pizzas Left: {numberOfPizzas}";
        if(numberOfPizzas <= 0)
        {
            AllDone();
        }
    }

    public void AllDone()
    {
        Debug.Log("All Done!!!!!!! ^_^");
    }
}
