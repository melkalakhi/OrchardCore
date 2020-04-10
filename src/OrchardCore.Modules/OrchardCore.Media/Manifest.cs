using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Media",
    Author = "The Orchard Team",
    Website = "https://orchardcore.net",
    Version = "1.0.0-rc2"
)]
[assembly: Feature(
    Id = "OrchardCore.Media",
    Name = "Media",
    Description = "The media module adds media management support.",
    Dependencies = new[]
    {
        "OrchardCore.ContentTypes"
    },
    Category = "Content Management"
)]

[assembly: Feature(
    Id = "OrchardCore.Media.Cache",
    Name = "Media Cache",
    Description = "The media cache module adds remote file store cache support.",
    Dependencies = new[]
    {
        "OrchardCore.Media"
    },
    Category = "Content Management"
)]
