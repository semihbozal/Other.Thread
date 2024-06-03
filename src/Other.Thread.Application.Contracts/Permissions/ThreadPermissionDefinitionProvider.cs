using Other.Thread.Permissions;
using OtherThread.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OtherThread.Permissions;

public class OtherThreadPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OtherThreadPermissions.GroupName);
        
        var accountingPermission = myGroup.AddPermission(OtherThreadPermissions.Accounts.HeaderPermission, L("Permission:Accounting"));

        var accountsPermission = accountingPermission.AddChild(OtherThreadPermissions.Accounts.Default, L("Permission:Accounting.Accounts"));
        accountsPermission.AddChild(OtherThreadPermissions.Accounts.Create, L("Permission:Accounting.Accounts.Create"));
        accountsPermission.AddChild(OtherThreadPermissions.Accounts.Edit, L("Permission:Accounting.Accounts.Edit"));
        accountsPermission.AddChild(OtherThreadPermissions.Accounts.Delete, L("Permission:Accounting.Accounts.Delete"));

        var definitionPermission = accountingPermission.AddChild(OtherThreadPermissions.Safes.HeaderPermission, L("Permission:Accounting.Definitions"));
        var safesPermission = definitionPermission.AddChild(OtherThreadPermissions.Safes.Default, L("Permission:Accounting.Safes"));
        safesPermission.AddChild(OtherThreadPermissions.Safes.Create, L("Permission:Accounting.Safes.Create"));
        safesPermission.AddChild(OtherThreadPermissions.Safes.Edit, L("Permission:Accounting.Safes.Edit"));
        safesPermission.AddChild(OtherThreadPermissions.Safes.Delete, L("Permission:Accounting.Safes.Delete"));

        var revenueGroupPermission = definitionPermission.AddChild(OtherThreadPermissions.RevenueGroups.Default, L("Permission:Accounting.RevenueGroups"));
        revenueGroupPermission.AddChild(OtherThreadPermissions.RevenueGroups.Create, L("Permission:Accounting.RevenueGroups.Create"));
        revenueGroupPermission.AddChild(OtherThreadPermissions.RevenueGroups.Edit, L("Permission:Accounting.RevenueGroups.Edit"));
        revenueGroupPermission.AddChild(OtherThreadPermissions.RevenueGroups.Delete, L("Permission:Accounting.RevenueGroups.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OtherThreadResource>(name);
    }
}
