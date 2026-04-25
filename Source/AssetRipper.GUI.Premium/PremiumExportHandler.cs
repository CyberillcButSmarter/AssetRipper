using AssetRipper.Export.Configuration;
using AssetRipper.Export.UnityProjects;
using AssetRipper.Processing;

namespace AssetRipper.GUI.Premium;

public sealed class PremiumExportHandler : ExportHandler
{
	public PremiumExportHandler(FullConfiguration settings) : base(settings)
	{
	}

	protected override IEnumerable<IAssetProcessor> GetProcessors()
	{
		foreach (IAssetProcessor processor in base.GetProcessors())
		{
			yield return processor;
		}
	}
}
