using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/MusicSound", order = 1)]
public class MusicSound : ScriptableObject
{
    [SerializeField] public float volume;
}