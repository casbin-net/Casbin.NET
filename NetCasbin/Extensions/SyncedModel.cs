﻿using Casbin.Model;

namespace Casbin.Extensions
{
    public static class SyncedModelExtension
    {
        public static IModel ToSyncModel(this IModel model)
        {
            if (model.IsSynchronized)
            {
                return model;
            }
            model.ReplacePolicyManager(ReaderWriterPolicyManager.Create());
            return model;
        }
    }
}
