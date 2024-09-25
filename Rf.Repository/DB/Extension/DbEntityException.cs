using System;
using System.Reflection;
using SqlSugar;

namespace Rf.CommonCommon.DB.Extension;

public static class DbEntityException
{
    public static object GetEntityTenant(this Type type)
    {
        var tenant = type.GetCustomAttribute<TenantAttribute>();
        return tenant?.configId;
    }
}