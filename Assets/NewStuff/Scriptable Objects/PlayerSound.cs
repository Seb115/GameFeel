using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PlayerSound", order = 1)]
public class PlayerSound : ScriptableObject
{
    [SerializeField]public float volume;
}
