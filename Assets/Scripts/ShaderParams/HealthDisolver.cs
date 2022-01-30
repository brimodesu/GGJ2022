using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisolver : MonoBehaviour
{
   [SerializeField] private EnemyController EnemyController;
   [SerializeField] private SkinnedMeshRenderer[] healthRenderers = new SkinnedMeshRenderer[0];

   private float targetDissolveValue = 1f;
   private float currentDissolveValue = 1f;

   private void OnEnable() => EnemyController.OnHealthChanged += HandleHealthChanged;
   private void OnDisable() => EnemyController.OnHealthChanged -= HandleHealthChanged;

   private void Start()
   {
      EnemyController = GetComponent<EnemyController>();
   }

   private void Update()
   {
      currentDissolveValue = Mathf.Lerp(currentDissolveValue, targetDissolveValue,2f * Time.deltaTime);
      foreach (Renderer render in healthRenderers)
      {
         foreach (var material in render.materials)
         {
            if(material.shader.name.Equals("Shader Graphs/Disolve"))
            {
               material.SetFloat("_Health", currentDissolveValue);
            }
         }
          //.SetFloat("_Health", currentDissolveValue);
      }
   }

   private void HandleHealthChanged(int health, int maxHealth)
   {
      targetDissolveValue = (float)health / maxHealth;
   }
}
