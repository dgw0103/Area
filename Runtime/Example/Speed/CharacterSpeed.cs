using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpeed : MonoBehaviour
{
    [SerializeField] private float speed = 1f;



    public float Speed { get => speed; set => speed = value; }
}