﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Rider.DockerFast.Blazor;

[Dependency(ReplaceServices = true)]
public class DockerFastBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DockerFast";
}
