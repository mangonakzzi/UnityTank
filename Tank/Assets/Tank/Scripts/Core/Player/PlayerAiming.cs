using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAiming : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform turrectTransform;

    private void LateUpdate()
    {
        Vector2 aimScreenPosition = inputReader.AimPosition;
        Vector2 aimWorldPosition =
            Camera.main.ScreenToWorldPoint(aimScreenPosition);
        turrectTransform.up = new Vector2(aimWorldPosition.x - turrectTransform.position.x,
            aimWorldPosition.y - turrectTransform.position.y);
    }
}
