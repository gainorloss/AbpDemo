using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Reflection;

namespace Product.Application.Constracts.Products
{
    public class ProductManagementPermissions
    {
        public const string GroupName = "ProductManagement";

        public static class Products
        {
            public const string Default = GroupName + ".Product";
            public const string Delete = Default + ".Delete";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";

        }
        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProductManagementPermissions));
        }
    }
}
