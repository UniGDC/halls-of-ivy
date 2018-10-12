using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {
    [SerializeField]
    private Text amount;
    [SerializeField]
    private float income;
    private float currentAmount = 0.00f;

    private float incomeTimer = 1f;
	// Use this for initialization
	void Start () {
        amount.text = currentAmount.ToString("n2");
    }
	
	// Update is called once per frame
	void Update () {
        incomeTimer -= Time.deltaTime;
        if(incomeTimer <= 0f){
            currentAmount += income ;
            amount.text = currentAmount.ToString("n2");
            incomeTimer = 1f;
        }
        
    }

    private void FixedUpdate()
    {
        
    }
}
