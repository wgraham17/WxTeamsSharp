﻿namespace WxTeamsSharp.Interfaces.General
{
    /// <summary>
    /// Includes ListErrors
    /// </summary>
    public interface IListable
    {
        /// <summary>
        /// Potential error when get multiple results
        /// </summary>
        IListError Error { get; }

        /// <summary>
        /// Whether there is an error in the result
        /// </summary>
        bool HasError { get; }
    }
}
