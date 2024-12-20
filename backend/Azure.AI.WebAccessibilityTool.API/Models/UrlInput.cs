﻿namespace AzureAI.WebAccessibilityTool.API.Models;

/// <summary>
/// Represents the input model for analyzing images.
/// </summary>
public class UrlInput
{
    /// <summary>
    /// Gets or sets the URL of the image to be analyzed.
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to get the image descriptions for alternative text.
    /// </summary>
    public bool? GetImageDescriptions { get; set; } = false;
}
