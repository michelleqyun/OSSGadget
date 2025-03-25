// Copyright (c) Microsoft Corporation. Licensed under the MIT License.

using System;

namespace Microsoft.CST.OpenSource.Model.Enums;

/// <summary>
/// Maven upstream repositories supported by Terrapin.
/// </summary>
public enum MavenSupportedUpstream
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
    /// Gets the registry URI for the maven upstream repository.
    /// </summary> michelleqyun: potentially rename method
    /// <param name="mavenUpstream">The <see cref="MavenSupportedUpstream"/>.</param>
    public static string GetRepositoryUrl(this MavenSupportedUpstream mavenUpstream) => mavenUpstream switch
    {
        MavenSupportedUpstream.MavenCentralRepository => "https://repo1.maven.org/maven2",
        MavenSupportedUpstream.GoogleMavenRepository => "https://maven.google.com/web/index.html#",
        MavenSupportedUpstream.GradlePluginsRepository => "https://plugins.gradle.org/m2", // michelleqyun: verify
        MavenSupportedUpstream.JitPackRepository => "https://jitpack.io", // michelleqyun: verify
        _ => throw new ArgumentOutOfRangeException(nameof(mavenUpstream), mavenUpstream, null),
    };

    /// <summary>
    /// Gets the download URI for the maven upstream repository.
    /// </summary> michelleqyun: potentially rename method
    /// <param name="mavenUpstream">The <see cref="MavenSupportUpstream"/>.</param>
    public static string GetDownloadRepositoryUrl(this MavenSupportedUpstream mavenUpstream) => mavenUpstream switch
    {
        MavenSupportedUpstream.MavenCentralRepository => "https://repo1.maven.org/maven2",
        MavenSupportedUpstream.GoogleMavenRepository => "https://dl.google.com/android/maven2",
        MavenSupportedUpstream.GradlePluginsRepository => "https://plugins.gradle.org/m2", // michelleqyun: verify
        MavenSupportedUpstream.JitPackRepository => "https://jitpack.io", // michelleqyun: verify
        _ => throw new ArgumentOutOfRangeException(nameof(mavenUpstream), mavenUpstream, null),
    };

    /// <summary>
    /// michelleqyun: better way to do this?
    /// </summary>
    /// <param name="mavenUpstream"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static MavenSupportedUpstream GetMavenSupportedUpstream(this string mavenUpstream) => mavenUpstream switch
    {
        "https://repo1.maven.org/maven2" => MavenSupportedUpstream.MavenCentralRepository,
        "https://dl.google.com/android/maven2" => MavenSupportedUpstream.GoogleMavenRepository,
        "https://plugins.gradle.org/m2" => MavenSupportedUpstream.GradlePluginsRepository, // michelleqyun: verify
        "https://jitpack.io" => MavenSupportedUpstream.JitPackRepository, // michelleqyun: verify
        _ => throw new ArgumentOutOfRangeException(nameof(mavenUpstream), mavenUpstream, null),
    };
}