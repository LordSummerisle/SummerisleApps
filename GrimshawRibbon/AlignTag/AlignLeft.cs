﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AlignTag
{
  [Transaction(TransactionMode.Manual)]
  internal class AlignLeft : IExternalCommand
  {
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
      return new Align().AlignElements(commandData, ref message, AlignType.Left);
    }
  }
}
