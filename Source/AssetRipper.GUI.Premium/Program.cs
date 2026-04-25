using AssetRipper.GUI.Premium;
using AssetRipper.GUI.Web;

GameFileLoader.ExportHandler = new PremiumExportHandler(GameFileLoader.Settings);
WebApplicationLauncher.Launch(args);
