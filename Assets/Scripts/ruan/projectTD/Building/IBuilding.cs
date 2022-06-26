using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ruan.projectTD.Building
{
  /// <summary>
  /// 建築實例化界面
  /// </summary>
  /// <typeparam name="TData"></typeparam>
  public interface IBuilding<out TData> where TData:IBuildingData
  {
    TData            Data     { get; }
    BuildingStrategy Strategy { get; set; }
    GameObject       GetGameObject();
    public void      OnBuild();
    public void      OnUpdate();
    public void      OnDestroy();
    public void      OnUpgrade();
  }
}