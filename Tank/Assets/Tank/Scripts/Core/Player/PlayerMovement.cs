using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("참조")]
    [SerializeField] private InputReader inputReader;
    [SerializeField] private Transform bodyTransform;
    [SerializeField] private Rigidbody2D rb;
    [Header("세팅")]
    [SerializeField] private float movementSpeed = 4f;
    [SerializeField] private float turningRate = 30f;

    private Vector2 previousMovement;

    private void OnEnable()
    {
        inputReader.MoveEvent += HandleMove;
    }

    private void OnDisable()
    {
        inputReader.MoveEvent -= HandleMove;
    }

    private void HandleMove(Vector2 vector)
    {
        previousMovement = vector;
    }

    private void Update()
    {
        float zRotation = previousMovement.x * -turningRate * Time.deltaTime;
        bodyTransform.Rotate(0f, 0f, zRotation);
    }

    private void FixedUpdate()
    {
        rb.velocity = (Vector2)bodyTransform.up * previousMovement.y * movementSpeed;
    }
}
