using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondDis : MonoBehaviour
{
   public TextMeshProUGUI diamondTmp;

   void OnValidated()
   {
      diamondTmp = GetComponent<TextMeshProUGUI>();
   }
   
   
   void Start()
      {
         DirGameDataManager.Ins.playerData.onChangeDiamond += i => OnChangeHelp(i);
         diamondTmp.text = $"x{DirGameDataManager.Ins.playerData.intHelp}";
      }

   private void OnChangeHelp(int i)
   {
      diamondTmp.text = $"x{i}";
   }
   
   void OnDestroy()
   {
      DirGameDataManager.Ins.playerData.onChangeDiamond -= i => OnChangeHelp(i);
   }
}
