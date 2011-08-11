﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla.Core;
using Csla.Rules;

namespace TransformationRules.Rules
{
  public class ToLower : Csla.Rules.BusinessRule
  {
    public ToLower(IPropertyInfo primaryProperty)
      : base(primaryProperty)
    {
      InputProperties = new List<IPropertyInfo>() { primaryProperty };
      AffectedProperties.Add(primaryProperty);
    }

    protected override void Execute(RuleContext context)
    {
      var value = (string)context.InputPropertyValues[PrimaryProperty];
      context.AddOutValue(PrimaryProperty, value.ToLower());
    }
  }
}
