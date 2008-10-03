﻿using System;

namespace Csla.Silverlight
{
  /// <summary>
  /// Interface that defines template that Navigatgor 
  /// control can understand.  This interface should be 
  /// implemented by controls that would rely on Navigator
  /// object to show them.
  /// </summary>
  public interface ISupportNavigation
  {
    /// <summary>
    /// This method is called by Navigatgor in order
    /// to pass parameters from a bookmark into 
    /// the shown control
    /// </summary>
    /// <param name="parameters">
    /// Parameters passed as string.  Is is up to control
    /// to parse them
    /// </param>
    void SetParameters(string parameters);
    string Title { get; }
  }
}
