﻿using optimalDb.Interfaces;

namespace optimalDb.BL.ConfigurationFileFormats;

public static class ConfigurationFileFormatFactory
{
    public static ConfigurationFileFormatCollection GetAllFileFormats()
    {
        return 
            new ConfigurationFileFormatCollection(
                new IConfigurationFileFormat?[]
                {
                    new JsonConfigurationFileFormat(),
                    new CfgConfigurationFileFormat()
                });
    }
}