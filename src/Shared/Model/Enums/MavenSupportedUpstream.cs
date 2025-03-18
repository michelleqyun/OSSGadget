// Copyright (c) Microsoft Corporation. Licensed under the MIT License.

using System;

namespace Microsoft.CST.OpenSource.Model.Enums;

/// <summary>
/// Maven upstream repositories supported by Terrapin.
/// </summary>
public enum MavenSupportUpstream
{
    /// <summary>
    /// https://repo1.maven.org/maven2
    /// </summary>
    MavenCentralRepository = 0,

    /// <summary>
    /// https://dl.google.com/android/maven2
    /// </summary>
    GoogleMavenRepository,

    /// <summary>
    /// https://plugins.gradle.org/m2
    /// </summary>
    GradlePluginsRepository,

    /// <summary>
    /// https://jitpack.io
    /// </summary>
    JitPackRepository,
}

/// <summary>
/// Extension methods for <see cref="MavenSupportUpstream"/>.
/// </summary>
public static class MavenSupportUpstreamExtensions
{
    /// <summary>
    /// Gets the download URI for the maven upstream repository.
    /// </summary> michelleqyun: potentially rename method
    /// <param name="mavenUpstream">The <see cref="MavenSupportUpstream"/>.</param>
    public static string GetRepositoryUrl(this MavenSupportUpstream mavenUpstream) => mavenUpstream switch
    {
        MavenSupportUpstream.MavenCentralRepository => "https://repo1.maven.org/maven2",
        MavenSupportUpstream.GoogleMavenRepository => "https://dl.google.com/android/maven2",
        MavenSupportUpstream.GradlePluginsRepository => "https://plugins.gradle.org/m2", // michelleqyun: verify
        MavenSupportUpstream.JitPackRepository => "https://jitpack.io", // michelleqyun: verify
        _ => throw new ArgumentOutOfRangeException(nameof(mavenUpstream), mavenUpstream, null),
    };
}