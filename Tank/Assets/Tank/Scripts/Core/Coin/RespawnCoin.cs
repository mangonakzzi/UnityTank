using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCoin : Coin
{
    public event Action<RespawnCoin> OnCollected;

    private Vector3 previousPosition;

    private void Update()
    {
        if(previousPosition != transform.position)
        {
            Show(true);
        }

        previousPosition = transform.position;
    }

    public override int Collect()
    {
        if (alreadyCollected) { return 0; }

        //OnCollected?.Invoke(this);

        gameObject.SetActive(false);
        alreadyCollected = true;
        return coinValue;
    }

    public void Reset()
    {
        alreadyCollected = false;
    }
}
