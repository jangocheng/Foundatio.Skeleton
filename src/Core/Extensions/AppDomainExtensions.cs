﻿using System;
using System.IO;

namespace Foundatio.Skeleton.Core.Extensions {
    public static class AppDomainExtensions {
        public static void SetDataDirectory(this AppDomain appDomain) {
            var path = Path.Combine(appDomain.BaseDirectory, "App_Data");
            if (Directory.Exists(path)) {
                appDomain.SetData("DataDirectory", path);
                return;
            }

            path = Path.Combine(appDomain.BaseDirectory, @"..\..\..\..\Api\App_Data");
            if (Directory.Exists(path)) {
                appDomain.SetData("DataDirectory", path);
                return;
            }

            path = Path.Combine(appDomain.BaseDirectory, @"..\..\..\..\App_Data");
            if (Directory.Exists(path))
                appDomain.SetData("DataDirectory", path);
        }
    }
}
