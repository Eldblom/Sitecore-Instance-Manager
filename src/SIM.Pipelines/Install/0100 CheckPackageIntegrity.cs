﻿namespace SIM.Pipelines.Install
{
  using Sitecore.Diagnostics.Base;
  using Sitecore.Diagnostics.Base.Annotations;

  #region

  #endregion

  [UsedImplicitly]
  public class CheckPackageIntegrity : InstallProcessor
  {
    #region Methods

    [UsedImplicitly]
    protected override void Process([NotNull] InstallArgs args)
    {
      Assert.ArgumentNotNull(args, "args");

      FileSystem.FileSystem.Local.Zip.CheckZip(args.PackagePath);
    }

    #endregion
  }
}