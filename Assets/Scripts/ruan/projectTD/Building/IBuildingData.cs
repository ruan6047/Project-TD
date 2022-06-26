using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ruan.projectTD.Building
{
  /// <summary>
  /// 建築物的基礎資料介面
  /// </summary>
  public interface IBuildingData
  {
    int    GetBaseCost();
    int    GetUpgradeCost();
    string GetName();
  }
}