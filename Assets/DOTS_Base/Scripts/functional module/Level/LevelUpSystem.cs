﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class LevelUpSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref LevelComponent levelComponent)=>{
            levelComponent.Level += 1f * Time.DeltaTime;
           // Debug.Log(levelComponent.Level);
        });
    }

   
}
